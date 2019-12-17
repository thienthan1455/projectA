create proc Cauthu_TimKiemCauthutheoten
(
	@TenCauThu nvarchar(50)
)
as select * from Cauthu
where TenCauThu=@TenCauThu