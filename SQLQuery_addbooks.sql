CREATE TABLE books
(
	BookID INT PRIMARY KEY IDENTITY(1,1),
	Timestamp DATETIME NOT NULL,
	Name VARCHAR(MAX) NOT NULL,
	Author VARCHAR(MAX) NOT NULL,
	Category VARCHAR(MAX) NOT NULL,
);


INSERT INTO books (Timestamp, Name, Author, Category) VALUES
(19890815, 'The 7 Habits of Highly Effective People', 'Stephen R. Covey', 'Self-help'),
(19361001, 'How to Win Friends and Influence People', 'Dale Carnegie', 'Self-help'),
(20181016, 'Atomic Habits', 'James Clear', 'Self-help'),
(19971006, 'The Power of Now', 'Eckhart Tolle', 'Self-help'),
(19370101, 'Think and Grow Rich', 'Napoleon Hill', 'Self-help'),
(19600711, 'To Kill a Mockingbird', 'Harper Lee', 'Novel'),
(19490608, '1984', 'George Orwell', 'Novel'),
(18130128, 'Pride and Prejudice', 'Jane Austen', 'Novel'),
(19250410, 'The Great Gatsby', 'F. Scott Fitzgerald', 'Novel'),
(18511018, 'Moby-Dick', 'Herman Melville', 'Novel'),
(20050101, 'Introduction to the Theory of Computation', 'Michael Sipser', 'Programming'),
(20080801, 'Clean Code', 'Robert C. Martin', 'Programming'),
(19991030, 'The Pragmatic Programmer', 'Andrew Hunt & David Thomas', 'Programming'),
(19941021, 'Design Patterns', 'Erich Gamma et al.', 'Programming'),
(20141227, 'You Don''t Know JS', 'Kyle Simpson', 'Programming'),
(20110913, 'The Lean Startup', 'Eric Ries', 'Business'),
(19970401, 'Rich Dad Poor Dad', 'Robert Kiyosaki', 'Business'),
(20011016, 'Good to Great', 'Jim Collins', 'Business'),
(19970601, 'The Innovator''s Dilemma', 'Clayton Christensen', 'Business'),
(20140916, 'Zero to One', 'Peter Thiel', 'Business');
