CREATE TABLE Users (
	UserID BIGINT PRIMARY KEY,
	LastName VARCHAR(99) NOT NULL,
	FirstName VARCHAR(99) NOT NULL,
	Email VARCHAR(99) NOT NULL UNIQUE,
	Pass VARCHAR(99) NOT NULL,
	Roles VARCHAR(99) NOT NULL
);

INSERT INTO Users (UserID, LastName, FirstName, Pass, Roles) VALUES
(1001, 'Arroyo', 'Hannah Yasmin', 'arroyo.283633@caloocan.sti.ph', '4everTWICE', 'Admin'),
(1002, 'Palomares', 'Christian Joseph', 'palomares.284363@caloocan.sti.ph', '101705090506', 'Admin'),
(1003, 'Umayam', 'Kenrick', 'umayam.282818@caloocan.sti.ph', 'PassMo', 'Admin'),
(1004, 'Alejo', 'Angelika', 'alejo.390527@caloocan.sti.ph', 'kahitAnoNa', 'Student'),
(1005, 'Lumabad', 'Shyroz', 'lumabad.421494@caloocan.sti.ph', 'lblyourHappiness', 'Student'),
(1006, 'Ramos', 'Cresta Jane', 'ramos.472859@caloocan.sti.ph' , 'Celestina_0528', 'Student'); 

CREATE TABLE Books (
	BookID BIGINT PRIMARY KEY,
	Title VARCHAR(99) NOT NULL,
	Author VARCHAR(99),
	Category VARCHAR(99) NOT NULL,
	Category VARCHAR(99) NOT NULL,
	Quantity INT NOT NULL
);

INSERT INTO Books (BookID, Title, Author, Category, Quantity) VALUES
(1, 'Management Accounting for Decision Makers', 'Peter Atrill and Eddie McLaney', 'Accountancy', 10),
(2, 'Principles of Management', 'Stephen P. Robbins and Mary A. Coulter', 'Business Management', 10),
(3, 'Vector Mechanics for Engineers: Statics and Dynamics', 'Ferdinand P. Beer and E. Russell Johnston', 'Engineering', 10),
(4, 'Entrepreneurship: Successfully Launching New Ventures', 'Bruce R. Barringer and R. Duane Ireland', 'Entrepreneurship', 10),
(5, 'To Kill a Mockingbird', 'Harper Lee', 'Fiction', 10),
(6, 'University Finances: Accounting and Budgeting Principles for Higher Education', 'Dean O. Smith', 'General Education', 10),
(7, 'Software Engineering (9th Edition)', 'Ian Sommerville', 'Information Technology', 10),
(8, 'Digital Arts: An Introduction to New Media', 'Catherine A. Hope and John Charles Ryan', 'Multimedia Arts', 10),
(9, 'Psychology (Global Edition)', 'Saundra K. Ciccarelli and J. Noland White', 'Psychology', 10),
(10, 'Tourism Management (Seventh Edition)', 'Stephen J. Page', 'Tourism', 10);

CREATE TABLE Request (
	RequestID BIGINT PRIMARY KEY,
	UserID BIGINT NOT NULL,
	BookID BIGINT NOT NULL,
	Status VARCHAR(99) NOT NULL,
	FOREIGN KEY (UserID) REFERENCES Users(UserID),
	FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

CREATE TABLE Borrow (
	BorrowID BIGINT PRIMARY KEY,
	RequestID BIGINT UNIQUE,
	UserID BIGINT NOT NULL,
	BookID BIGINT NOT NULL,
	BorrowDate DATE NOT NULL,
	ReturnDate DATE NOT NULL,
	FOREIGN KEY (RequestID) REFERENCES Request(RequestID),
	FOREIGN KEY (UserID) REFERENCES Users(UserID),
	FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

CREATE TABLE ReturnConfirm (
	ReturnID BIGINT PRIMARY KEY,
	BorrowID BIGINT UNIQUE,
	UserID BIGINT NOT NULL,
	BookID BIGINT NOT NULL,
	ReturnDate DATE NOT NULL,
	FOREIGN KEY (BorrowID) REFERENCES Borrow(BorrowID),
	FOREIGN KEY (UserID) REFERENCES Users(UserID),
	FOREIGN KEY (BookID) REFERENCES Books(BookID)
);