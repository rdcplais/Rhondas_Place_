Update Candles
Set CandleImgUrl = '~\Content\Images\Jar Candle2.png'
Where CandleId = 2


Insert Into Candles
Values(1, 1, '8 oz Jelly', 8, '~\Content\Images\Jar Candle2.png'), 
(1, 2, '12 oz Classic', 13, '~\Content\Images\Jar Candle.jpg'), 
(1, 3, '16 oz Jelly', 16, '~\Content\Images\untitled.png'), 
(1, 4, '16 oz Jelly', 18, '~\Content\Images\untitled.png')
Select * From Candles

Insert Into CandleCategories
Values('Jar Candles', 'Jar Candles'), 
('Cubed Candles', 'Cubed Candles'), 
('Halloween Candles', 'Halloween Candles'), 
('Fall Candles', 'Fall Candles'), 
('Christmas Candles', 'Christmas Candles'), 
('Festive Candles', 'Festive  Candles'), 
('Large Candles', 'Large  Candles'), 
('Medium Candles', 'Medium  Candles'), 
('Small Candles', 'Small  Candles'), 
('Vase Candles', 'Vase  Candles'), 
('Shop By Color', 'Shop By Color'), 
('Best Selling Candles', 'Best Selling Candles')

Select * From CandleCategories


Insert Into CandleScents
Values('Butter Cream'), 
('Cucumber Melon'), 
('Blackberry'), 
('Blueberry'), 
('Strawberries & Cream'), 
('Vanilla')

Select * From CandleScents
