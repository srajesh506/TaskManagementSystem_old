USE [TMS]
GO
SET IDENTITY_INSERT [dbo].[Rolemaster] ON 

INSERT [dbo].[Rolemaster] ([Roleid], [RoleName], [IsAdmin], [createdate], [modifydate]) VALUES (1, N'Admin', 1, CAST(0x0000AF5500011CDF AS DateTime), CAST(0x0000AF5500011CDF AS DateTime))
INSERT [dbo].[Rolemaster] ([Roleid], [RoleName], [IsAdmin], [createdate], [modifydate]) VALUES (2, N'Manager', 1, CAST(0x0000AF55000133A2 AS DateTime), CAST(0x0000AF55000133A2 AS DateTime))
INSERT [dbo].[Rolemaster] ([Roleid], [RoleName], [IsAdmin], [createdate], [modifydate]) VALUES (3, N'Employee', 1, CAST(0x0000AF550001559C AS DateTime), CAST(0x0000AF550001559C AS DateTime))
SET IDENTITY_INSERT [dbo].[Rolemaster] OFF
