CREATE TABLE Customer(
	CustomerID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	CustomerName VARCHAR(50) NOT NULL,
	CustomerEmail VARCHAR(50) NOT NULL,
	CustomerPassword VARCHAR(50) NOT NULL,
	CustomerAddress VARCHAR(100) NOT NULL,
	CustomerRole VARCHAR(50) NOT NULL
)

CREATE TABLE TransactionHeader(
	TransactionID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	TransactionDate DATE NOT NULL,
	CustomerID INT NOT NULL,
	FOREIGN KEY ([CustomerID]) REFERENCES Customer([CustomerID])
)

CREATE TABLE Artist(
	ArtistID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ArtistName VARCHAR(50) NOT NULL,
	ArtistImage VARCHAR(50) NOT NULL,
)

CREATE TABLE Album(
	AlbumID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ArtistID INT NOT NULL,
	AlbumName VARCHAR(50) NOT NULL,
	AlbumImage VARCHAR(50) NOT NULL,
	AlbumPrice INT NOT NULL,
	AlbumStock INT NOT NULL,
	AlbumDescription VARCHAR(255) NOT NULL,
	FOREIGN KEY ([ArtistID]) REFERENCES Artist([ArtistID])

)

CREATE TABLE TransactionDetail(
	TransactionID INT NOT NULL,
	AlbumID INT NOT NULL,
	Quantity INT NOT NULL,
	PRIMARY KEY ([TransactionID], [AlbumID]),
	FOREIGN KEY ([TransactionID]) REFERENCES TransactionHeader([TransactionID]),
	FOREIGN KEY ([AlbumID]) REFERENCES Album([AlbumID])
)

CREATE TABLE Cart(
	CustomerID INT NOT NULL,
	AlbumID INT NOT NULL,
	Quantity INT NOT NULL,
	PRIMARY KEY ([CustomerID], [AlbumID]),
	FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
	FOREIGN KEY ([AlbumID]) REFERENCES Album([AlbumID])
)