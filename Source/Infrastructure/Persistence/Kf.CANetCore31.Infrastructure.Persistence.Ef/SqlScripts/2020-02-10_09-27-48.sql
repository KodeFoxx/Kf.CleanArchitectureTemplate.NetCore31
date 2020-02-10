﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [People] (
    [id] BIGINT NOT NULL IDENTITY,
    [firstName] NVARCHAR NULL,
    [lastName] NVARCHAR NULL,
    CONSTRAINT [PK_People] PRIMARY KEY ([id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200210082735_Initial', N'3.1.1');

GO

