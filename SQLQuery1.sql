SELECT COUNT(UserId)
FROM Users
WHERE Admin LIKE '1';

INSERT INTO Users (userName, password, Admin)
VALUES ('el1212', 'ab123456', 0);