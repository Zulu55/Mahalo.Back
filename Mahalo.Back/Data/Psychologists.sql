INSERT [dbo].[Psychologists] ([Name], [Address], [XCoordinate], [YCoordinate], [OfficeStart], [OfficeEnd], [TerapyPrice], [IsActive], [CreationDate], [CityId]) VALUES (N'Leidy Catherine Delgado Paladines', N'Calle 1 #2 3', 2.0, 3.0, GETDATE(), GETDATE(), 25000, 1, GETDATE(),  (SELECT top 1 Id from Cities where Name = 'Medellin'))