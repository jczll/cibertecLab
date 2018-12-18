USE [Chinook]
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarTrackName]    Script Date: 10/10/2018 19:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_BuscarTrackName] 
@TrackName nvarchar(200)
as
begin 
select TrackId,Album.Title as Album_title,Artist.[Name] as Artist_name,Track.[Name] as Track_name,Track.UnitPrice
       from Track 
	        left join Album on Album.AlbumId=Track.AlbumId 
			left join Artist on Artist.ArtistId=album.ArtistId   
       where Track.[Name] like '%'+@TrackName+'%'
end