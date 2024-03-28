
-- Sports Table
CREATE TABLE Sports (
    RefNo INT PRIMARY KEY,
    Name VARCHAR(50)
);

-- Coaches Table
CREATE TABLE Coaches (
    RefNo INT PRIMARY KEY,
    Fname VARCHAR(50),
    Lname VARCHAR(50),
    DOB DATE,
    Gender VARCHAR(10),
    Address VARCHAR(100),
    Email VARCHAR(100),
    Contact VARCHAR(20),
    Emname VARCHAR(50),
    EmContact VARCHAR(20),
    MC VARCHAR(20),
    Sport VARCHAR(50),
    Skill VARCHAR(50),
    Username VARCHAR(50),
    Password VARCHAR(50)
);

-- Managers Table
CREATE TABLE Managers (
    RefNo INT PRIMARY KEY,
    Fname VARCHAR(50),
    Lname VARCHAR(50),
    DOB DATE,
    Gender VARCHAR(10),
    Address VARCHAR(100),
    Email VARCHAR(100),
    Contact VARCHAR(20),
    Emname VARCHAR(50),
    EmContact VARCHAR(20),
    MC VARCHAR(20),
    Sport VARCHAR(50),
    Skill VARCHAR(50),
    Username VARCHAR(50),
    Password VARCHAR(50)
);

-- Members Table
CREATE TABLE Members (
    RefNo INT PRIMARY KEY,
    Fname VARCHAR(50),
    Lname VARCHAR(50),
    DOB DATE,
    Gender VARCHAR(10),
    Address VARCHAR(100),
    Email VARCHAR(100),
    Contact VARCHAR(20),
    Emname VARCHAR(50),
    EmContact VARCHAR(20),
    MC VARCHAR(20),
    Sport VARCHAR(50),
    Skill VARCHAR(50),
    Username VARCHAR(50),
    Password VARCHAR(50)
);

-- Admins Table
CREATE TABLE Admins (
    RefNo INT PRIMARY KEY,
    Fname VARCHAR(50),
    Lname VARCHAR(50),
    DOB DATE,
    Gender VARCHAR(10),
    Address VARCHAR(100),
    Email VARCHAR(100),
    Contact VARCHAR(20),
    MC VARCHAR(20),
    Username VARCHAR(50),
    Password VARCHAR(50)
);

-- AllUsers Table
CREATE TABLE AllUsers (
    RefNo INT PRIMARY KEY,
    UserType VARCHAR(20),
    Fname VARCHAR(50),
    Lname VARCHAR(50),
    DOB DATE,
    Gender VARCHAR(10),
    Address VARCHAR(100),
    Email VARCHAR(100),
    Contact VARCHAR(20),
    Emname VARCHAR(50),
    EmContact VARCHAR(20),
    MC VARCHAR(20),
    Sport VARCHAR(50), 
    Skill VARCHAR(50),
    Username VARCHAR(50),
    Password VARCHAR(50)
);

-- Feedback Table
CREATE TABLE Feedback (
    RefNo INT PRIMARY KEY,
    Feedback TEXT
);

-- Competitions Table
CREATE TABLE Competitions (
    RefNo INT PRIMARY KEY,
    CompName VARCHAR(100),
    SportName VARCHAR(50),
    Date DATE,
    Time TIME,
    Member VARCHAR(100)
);

-- Training Schedule Table
CREATE TABLE TrainingSchedule (
    FK_Coach_RefNo INT,
    Date DATE,
    Time TIME,
    FK_Sports_RefNo INT,
    FOREIGN KEY (FK_Coach_RefNo) REFERENCES Coaches(RefNo),
    FOREIGN KEY (FK_Sports_RefNo) REFERENCES Sports(RefNo)
);

-- Fees Table
CREATE TABLE Fees (
    FK_Member_RefNo INT,
    Date DATE,
    FOREIGN KEY (FK_Member_RefNo) REFERENCES Members(RefNo)
);

-- Salary Table
CREATE TABLE Salary (
    FK_Coach_RefNo INT,
    FOREIGN KEY (FK_Coach_RefNo) REFERENCES Coaches(RefNo)
);

-- Monthly Income Table
CREATE TABLE MonthlyIncome (
    Income DECIMAL(10,2),
    Expenses DECIMAL(10,2),
    Profit DECIMAL(10,2)
);

-- Result Table
CREATE TABLE Result (
    RefNo INT PRIMARY KEY,
    SportName VARCHAR(50),
    Date DATE,
    Time TIME,
    Member INT, -- Assuming Member is an INT data type in both tables
    Result VARCHAR(50),
    FOREIGN KEY (Member) REFERENCES Members(RefNo)
);

-- Waiting List Table
CREATE TABLE WaitingList (
    RefNo INT PRIMARY KEY,
    Fname VARCHAR(50),
    Lname VARCHAR(50),
    DOB DATETIME
);
CREATE TABLE PlayProgress (
    FK_Member_RefNo INT,
    Feedback TEXT,
    FOREIGN KEY (FK_Member_RefNo) REFERENCES Members(RefNo)
);

-- Recommendations Table
CREATE TABLE Recommendations (
    FK_Member_RefNo INT,
    FK_Comp_RefNo INT,
    FOREIGN KEY (FK_Member_RefNo) REFERENCES Members(RefNo),
    FOREIGN KEY (FK_Comp_RefNo) REFERENCES Competitions(RefNo)
);
CREATE TABLE PaymentDetails (
    FK_Member_RefNo INT,
    SlipNo VARCHAR(50),
    FOREIGN KEY (FK_Member_RefNo) REFERENCES Members(RefNo)
);