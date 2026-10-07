CREATE TABLE books
(
	BookID INT PRIMARY KEY IDENTITY(1,1),
	Timestamp DATETIME NOT NULL,
	Name VARCHAR(MAX) NOT NULL,
	Author VARCHAR(MAX) NOT NULL,
	Category VARCHAR(MAX) NOT NULL,
);

INSERT INTO books (Timestamp, Name, Author, Category) VALUES
('1989-08-15', 'The 7 Habits of Highly Effective People', 'Stephen R. Covey', 'Self-help'),
('1936-10-01', 'How to Win Friends and Influence People', 'Dale Carnegie', 'Self-help'),
('2018-10-16', 'Atomic Habits', 'James Clear', 'Self-help'),
('1997-10-06', 'The Power of Now', 'Eckhart Tolle', 'Self-help'),
('1937-01-01', 'Think and Grow Rich', 'Napoleon Hill', 'Self-help'),
('1960-07-11', 'To Kill a Mockingbird', 'Harper Lee', 'Novel'),
('1949-06-08', '1984', 'George Orwell', 'Novel'),
('1813-01-28', 'Pride and Prejudice', 'Jane Austen', 'Novel'),
('1925-04-10', 'The Great Gatsby', 'F. Scott Fitzgerald', 'Novel'),
('1851-10-18', 'Moby-Dick', 'Herman Melville', 'Novel'),
('2005-01-01', 'Introduction to the Theory of Computation', 'Michael Sipser', 'Programming'),
('2008-08-01', 'Clean Code', 'Robert C. Martin', 'Programming'),
('1999-10-30', 'The Pragmatic Programmer', 'Andrew Hunt & David Thomas', 'Programming'),
('1994-10-21', 'Design Patterns', 'Erich Gamma et al.', 'Programming'),
('2014-12-27', 'You Don''t Know JS', 'Kyle Simpson', 'Programming'),
('2011-09-13', 'The Lean Startup', 'Eric Ries', 'Business'),
('1997-04-01', 'Rich Dad Poor Dad', 'Robert Kiyosaki', 'Business'),
('2001-10-16', 'Good to Great', 'Jim Collins', 'Business'),
('1997-06-01', 'The Innovator''s Dilemma', 'Clayton Christensen', 'Business'),
('2014-09-16', 'Zero to One', 'Peter Thiel', 'Business');
