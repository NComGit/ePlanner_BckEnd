use EPlannerDB;

-- User Table
CREATE TABLE Users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(255) UNIQUE NOT NULL,
    password NVARCHAR(255) NOT NULL
);
 
-- TodoLists Table
CREATE TABLE TodoLists (
    id INT IDENTITY(1,1) PRIMARY KEY,
    userId INT NOT NULL,
    title NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX) NULL,
    FOREIGN KEY (userId) REFERENCES Users(id)
);
 
-- TodoItems Table
CREATE TABLE TodoItems (
    id INT IDENTITY(1,1) PRIMARY KEY,
    todoListId INT NOT NULL,
    title NVARCHAR(255) NOT NULL,
    complete_incomplete NVARCHAR(50) NOT NULL DEFAULT 'incomplete',
    userDelegatedToId INT NULL,
    dueDate DATE NULL,
    FOREIGN KEY (todoListId) REFERENCES TodoLists(id),
    FOREIGN KEY (userDelegatedToId) REFERENCES Users(id)
);
 
-- TodoListAccess Table
CREATE TABLE TodoListAccess (
    id INT IDENTITY(1,1) PRIMARY KEY,
    todoListId INT NOT NULL,
    userId INT NOT NULL,
    FOREIGN KEY (todoListId) REFERENCES TodoLists(id),
    FOREIGN KEY (userId) REFERENCES Users(id)
);