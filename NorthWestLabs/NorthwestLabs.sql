CREATE DATABASE NorthwestLabs;
GO

USE NorthwestLabs;
GO

---Create table job title
CREATE TABLE [Job_Title] (
  [jobTitleID] int NOT NULL PRIMARY KEY,
  [jobDescription] varchar(30) NOT NULL
)
GO


---Create table company info
CREATE TABLE [Company_Info] (
  [companyID] int NOT NULL PRIMARY KEY,
  [companyName] varchar(30),
  [companyAddress] varchar(30),
  [companyPhone] varchar(10),
  [companyEmail] varchar(30)
)
GO

---Create table employee
CREATE TABLE [Employee] (
  [employeeID] int NOT NULL PRIMARY KEY,
  [employeeFirstName] varchar(30),
  [employeeLastName] varchar(30),
  [address] varchar(30),
  [city] varchar(30),
  [state] varchar(30),
  [zip] varchar(5),
  [phone] varchar(10),
  [email] varchar(30),
  [userName] varchar(30),
  [password] varchar(30),
  [jobTitleID] int NOT NULL FOREIGN KEY REFERENCES Job_Title(jobTitleID),
  [companyID] int NOT NULL FOREIGN KEY REFERENCES Company_Info(companyID)
)
GO


---Create table contact
CREATE TABLE [Contact] (
  [contactID] int NOT NULL PRIMARY KEY,
  [contactFirstName] varchar(30),
  [contactLastName] varchar(30),
  [phone] varchar(10),
  [email] varchar(30)
)
GO


---Create table vendor
CREATE TABLE [Vendor] (
  [vendorID] int NOT NULL PRIMARY KEY,
  [vendorName] varchar(30),
  [vendorAddress] varchar(30),
  [ZIP] varchar(5),
  [city] varchar(30),
  [state] varchar(30),
  [contactID] int NOT NULL FOREIGN KEY REFERENCES Contact(contactID)
)
GO


---Create table inventory
CREATE TABLE [Inventory] (
  [inventoryID] int NOT NULL PRIMARY KEY,
  [inventoryName] varchar(30),
  [inventoryDescription] varchar(30),
  [vendorID] int NOT NULL FOREIGN KEY REFERENCES Vendor(vendorID)
)
GO


---Create table customer
CREATE TABLE [Customer] (
  [customerID] int NOT NULL PRIMARY KEY,
  [customerName] varchar(30),
  [billingAddress] varchar(30),
  [ZIP] varchar(5),
  [userName] varchar(30),
  [password] varchar(30),
  [email] varchar(30),
  [city] varchar(30),
  [state] varchar(30),
  [notes] varchar(30),
  [contactID] int NOT NULL FOREIGN KEY REFERENCES Contact(contactID)
)
GO


---Create table work order
CREATE TABLE [Work_Order] (
  [LTNum] int NOT NULL PRIMARY KEY,
  [dateReceived] date,
  [dateFinished] date,
  [dueDate] date,
  [customerID] int NOT NULL FOREIGN KEY REFERENCES Customer(customerID)
)
GO


---Create table invoice
CREATE TABLE [Invoice] (
  [invoiceID] int NOT NULL PRIMARY KEY,
  [totalPrice] decimal,
  [paymentTerms] varchar(30),
  [printDate] date,
  [commentsInfo] varchar(30),
  [companyID] int NOT NULL FOREIGN KEY REFERENCES Company_Info(companyID),
  [employeeID] int NOT NULL FOREIGN KEY REFERENCES Employee(employeeID),
  [LTNum] int NOT NULL FOREIGN KEY REFERENCES Work_Order(LTNum)
)
GO


---Create table assay test
CREATE TABLE [Assay_Test] (
  [assayNumber] int NOT NULL PRIMARY KEY,
  [assayName] varchar(30),
  [assayDescription] varchar(30),
  [assayCost] decimal
)
GO


---Create table WO compound
CREATE TABLE [WO_Compound] (
  [CSC] int NOT NULL PRIMARY KEY,
  [assayNumber] int NOT NULL FOREIGN KEY REFERENCES Assay_Test(assayNumber),
  [passedTest] bit,
  [hoursWorked] decimal,
  [totalPrice] decimal,
  [quantity] decimal,
  [actualWeight] decimal,
  [molecularMass] decimal,
  [clientIndicatedWeight] decimal,
  [dateStarted] date,
  [dateFinished] date,
  [MTD] decimal,
  [LTNum] int NOT NULL FOREIGN KEY REFERENCES Work_Order(LTNum),
  [employeeID] int NOT NULL FOREIGN KEY REFERENCES Employee(employeeID)
)
GO


---Create table quote
CREATE TABLE [Quote] (
  [quoteID] int NOT NULL PRIMARY KEY,
  [employeeID] int,
  [quotePrice] decimal,
  [customerID] int NOT NULL FOREIGN KEY REFERENCES Customer(customerID)
)
GO


---Create table compound_quote
CREATE TABLE [Compound_Quote] (
  [quoteID] int NOT NULL FOREIGN KEY REFERENCES Quote(quoteID),
  [CSC] int NOT NULL FOREIGN KEY REFERENCES WO_Compound(CSC)
  CONSTRAINT pk_Compound_QuoteID PRIMARY KEY (quoteID,CSC)
)
GO


---Create table day
CREATE TABLE [Day] (
  [dayCode] varchar(2) NOT NULL PRIMARY KEY,
  [dayName] varchar(30)
)
GO


---Create table test schedule
CREATE TABLE [Test_Schedule] (
  [dayCode] varchar(2) NOT NULL FOREIGN KEY REFERENCES Day(dayCode),
  [assayNumber] int NOT NULL FOREIGN KEY REFERENCES Assay_Test(assayNumber),
  [weekNumber] int
  CONSTRAINT pk_Test_ScheduleID PRIMARY KEY (dayCode,assayNumber)
)
GO
