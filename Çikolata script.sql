USE [Çikolata]
GO
/****** Object:  Table [dbo].[AGiriş]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AGiriş](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[AdminAdı] [varchar](50) NULL,
	[Şifre] [varchar](50) NULL,
 CONSTRAINT [PK_AGiriş] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Müşteriler]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Müşteriler](
	[MüşteriID] [int] IDENTITY(1,1) NOT NULL,
	[MüşteriAdı] [varchar](50) NULL,
	[MüşteriSoyadı] [varchar](50) NULL,
	[Adres] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Telefon] [int] NULL,
 CONSTRAINT [PK_Müşteriler] PRIMARY KEY CLUSTERED 
(
	[MüşteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ödemeler]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ödemeler](
	[ÖdemeID] [int] IDENTITY(1,1) NOT NULL,
	[Ücret] [money] NULL,
	[ÖdemeTarihi] [datetime] NULL,
	[ÖdemeTürü] [varchar](50) NULL,
	[MüşteriID] [int] NULL,
 CONSTRAINT [PK_Ödemeler] PRIMARY KEY CLUSTERED 
(
	[ÖdemeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Siparişler]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparişler](
	[SiparişID] [int] IDENTITY(1,1) NOT NULL,
	[SiparişTarihi] [datetime] NULL,
	[SiparişAdet] [int] NULL,
	[MüşteriID] [int] NULL,
 CONSTRAINT [PK_Siparişler] PRIMARY KEY CLUSTERED 
(
	[SiparişID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ürünler]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ürünler](
	[ÜrünID] [int] IDENTITY(1,1) NOT NULL,
	[ÜrünAdı] [varchar](50) NULL,
	[ÜrünÖzellik] [varchar](50) NULL,
	[ÜrünAdet] [int] NULL,
	[TürID] [int] NULL,
	[ÖdemeID] [int] NULL,
	[MüşteriID] [int] NULL,
 CONSTRAINT [PK_Ürünler] PRIMARY KEY CLUSTERED 
(
	[ÜrünID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ÜrünTür]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ÜrünTür](
	[TürID] [int] IDENTITY(1,1) NOT NULL,
	[TürAdı] [varchar](50) NULL,
 CONSTRAINT [PK_ÜrünTür] PRIMARY KEY CLUSTERED 
(
	[TürID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Üyeler]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Üyeler](
	[ÜyeID] [int] IDENTITY(1,1) NOT NULL,
	[ÜyeAdı] [varchar](50) NULL,
	[ÜyeSoyadı] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Şifre] [varchar](50) NULL,
 CONSTRAINT [PK_Üyeler] PRIMARY KEY CLUSTERED 
(
	[ÜyeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Ödemeler]  WITH CHECK ADD  CONSTRAINT [FK_Ödemeler_Müşteriler] FOREIGN KEY([MüşteriID])
REFERENCES [dbo].[Müşteriler] ([MüşteriID])
GO
ALTER TABLE [dbo].[Ödemeler] CHECK CONSTRAINT [FK_Ödemeler_Müşteriler]
GO
ALTER TABLE [dbo].[Siparişler]  WITH CHECK ADD  CONSTRAINT [FK_Siparişler_Müşteriler] FOREIGN KEY([MüşteriID])
REFERENCES [dbo].[Müşteriler] ([MüşteriID])
GO
ALTER TABLE [dbo].[Siparişler] CHECK CONSTRAINT [FK_Siparişler_Müşteriler]
GO
ALTER TABLE [dbo].[Ürünler]  WITH CHECK ADD  CONSTRAINT [FK_Ürünler_Müşteriler] FOREIGN KEY([MüşteriID])
REFERENCES [dbo].[Müşteriler] ([MüşteriID])
GO
ALTER TABLE [dbo].[Ürünler] CHECK CONSTRAINT [FK_Ürünler_Müşteriler]
GO
ALTER TABLE [dbo].[Ürünler]  WITH CHECK ADD  CONSTRAINT [FK_Ürünler_Ödemeler] FOREIGN KEY([ÖdemeID])
REFERENCES [dbo].[Ödemeler] ([ÖdemeID])
GO
ALTER TABLE [dbo].[Ürünler] CHECK CONSTRAINT [FK_Ürünler_Ödemeler]
GO
ALTER TABLE [dbo].[Ürünler]  WITH CHECK ADD  CONSTRAINT [FK_Ürünler_ÜrünTür] FOREIGN KEY([TürID])
REFERENCES [dbo].[ÜrünTür] ([TürID])
GO
ALTER TABLE [dbo].[Ürünler] CHECK CONSTRAINT [FK_Ürünler_ÜrünTür]
GO
/****** Object:  StoredProcedure [dbo].[AGirişi]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AGirişi]
@AdminAdı varchar(50),
@Şifre varchar(50)
as
select *from AGiriş where AdminAdı=@AdminAdı and Şifre=@Şifre
GO
/****** Object:  StoredProcedure [dbo].[Getir]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Getir]
@ÜyeAdı varchar(50),
@Şifre varchar(50)
as begin
select *from Üyeler where ÜyeAdı=@ÜyeAdı and Şifre=@Şifre
end


GO
/****** Object:  StoredProcedure [dbo].[MüşteriAra]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MüşteriAra]
@MüşteriID int,
@MüşteriAdı varchar(50),
@MüşteriSoyadı varchar(50),
@Adres varchar(50),
@Email varchar(50),
@Telefon int
as begin
select *from Müşteriler where MüşteriID  like @MüşteriID or
MüşteriAdı like @MüşteriAdı or
MüşteriSoyadı like @MüşteriSoyadı or
Adres like @Adres or
Email like @Email or
Telefon like @Telefon 
end 

GO
/****** Object:  StoredProcedure [dbo].[MüşteriAraID]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MüşteriAraID]
@MüşteriID int
as begin
select *from Müşteriler where MüşteriID like @MüşteriID
end


GO
/****** Object:  StoredProcedure [dbo].[MüşteriEkle]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MüşteriEkle]
@MüşteriAdı varchar(50),
@MüşteriSoyadı varchar(50),
@Adres varchar(50),
@Email varchar(50),
@Telefon int
as 
insert into Müşteriler(MüşteriAdı,MüşteriSoyadı,Adres,Email,Telefon) 
values(@MüşteriAdı,@MüşteriSoyadı,@Adres,@Email,@Telefon)

GO
/****** Object:  StoredProcedure [dbo].[MüşteriGörüntüle]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MüşteriGörüntüle]
as begin
select *from Müşteriler
end


GO
/****** Object:  StoredProcedure [dbo].[MüşteriGüncelle]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MüşteriGüncelle]
@MüşteriID int,
@MüşteriAdı varchar(50),
@MüşteriSoyadı varchar(50),
@Adres varchar(50),
@Email varchar(50),
@Telefon int
as begin
Update Müşteriler set MüşteriAdı=@MüşteriAdı,MüşteriSoyadı=@MüşteriSoyadı,Adres=@Adres,
Email=@Email,Telefon=@Telefon where MüşteriID=@MüşteriID
set nocount on;
end


GO
/****** Object:  StoredProcedure [dbo].[MüşteriListeleCombo]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MüşteriListeleCombo]
as begin
select MüşteriID from Müşteriler
end


GO
/****** Object:  StoredProcedure [dbo].[MüşteriSil]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MüşteriSil]
@MüşteriID int
as begin
delete from Müşteriler where MüşteriID=@MüşteriID
end


GO
/****** Object:  StoredProcedure [dbo].[OdeListele]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OdeListele]
as  
select ÖdemeID from Ödemeler
GO
/****** Object:  StoredProcedure [dbo].[SiparisEkle]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SiparisEkle]
@SiparişTarihi datetime,
@SiparişAdet int,
@MüşteriID int
as 
insert into Siparişler(SiparişTarihi,SiparişAdet,MüşteriID) 
values(@SiparişTarihi,@SiparişAdet,@MüşteriID) 
GO
/****** Object:  StoredProcedure [dbo].[SiparisGörüntüle]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SiparisGörüntüle]
as
select *from Siparişler

GO
/****** Object:  StoredProcedure [dbo].[SiparisID]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SiparisID]
as
select SiparişID from Siparişler
GO
/****** Object:  StoredProcedure [dbo].[SiparisIDArama]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SiparisIDArama]
@SiparişID int
as begin
select *from Siparişler where SiparişID like @SiparişID
end
GO
/****** Object:  StoredProcedure [dbo].[SiparisSil]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SiparisSil]
@SiparişID int
as begin
delete from Siparişler where SiparişID=@SiparişID
end
GO
/****** Object:  StoredProcedure [dbo].[SiparişGüncelle]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SiparişGüncelle]
@SiparişID int,
@SiparişTarihi datetime,
@SiparişAdet int,
@MüşteriID int
as begin
Update Siparişler set SiparişTarihi=@SiparişTarihi,SiparişAdet=@SiparişAdet,
MüşteriID=@MüşteriID where SiparişID=@SiparişID
set nocount on;
end
GO
/****** Object:  StoredProcedure [dbo].[TürIDlistele]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TürIDlistele]
as begin 
select TürID from ÜrünTür
end
GO
/****** Object:  StoredProcedure [dbo].[ÜrünEkle]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ÜrünEkle]
@ÜrünAdı varchar(50),
@ÜrünÖzellik varchar(50),
@ÜrünAdet int,
@TürID int,
@ÖdemeID int,
@MüşteriID int 
as 
insert into Ürünler(ÜrünAdı,ÜrünÖzellik,ÜrünAdet,TürID,ÖdemeID,MüşteriID) 
values(@ÜrünAdı,@ÜrünÖzellik,@ÜrünAdet,@TürID,@ÖdemeID,@MüşteriID) 


GO
/****** Object:  StoredProcedure [dbo].[ÜrünGörüntüle]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ÜrünGörüntüle]
as
select *from Ürünler
GO
/****** Object:  StoredProcedure [dbo].[ÜrünIDArama]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ÜrünIDArama]
@ÜrünID int
as begin
select *from Ürünler where ÜrünID like @ÜrünID
end
GO
/****** Object:  StoredProcedure [dbo].[ÜrünListeleCombo]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ÜrünListeleCombo]
as begin 
select ÜrünID from Ürünler
end
GO
/****** Object:  StoredProcedure [dbo].[ÜyeOl]    Script Date: 8.04.2019 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ÜyeOl]
@ÜyeAdı varchar(50),
@ÜyeSoyadı varchar(50),
@Email varchar(50),
@Şifre varchar(50)
as 
insert into Üyeler(ÜyeAdı,ÜyeSoyadı,Email,Şifre) values(@ÜyeAdı,@ÜyeSoyadı,@Email,@Şifre)


GO
 

create proc Hesap
as
select MüşteriAdı,MüşteriSoyadı,ÜrünAdı,ÜrünAdet,Ücret from Müşteriler m inner join Ürünler ü on m.MüşteriID=ü.MüşteriID
inner join Ödemeler ö on ö.MüşteriID=m.MüşteriID inner join Siparişler s on s.MüşteriID=ü.MüşteriID 
exec Hesap

