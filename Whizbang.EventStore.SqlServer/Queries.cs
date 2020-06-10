namespace Whizbang.EventStore.MsSql
{
    public sealed class Queries
    {
        public const string InsertEventSql = @"
INSERT INTO [EventStore].[dbo].[Events]
           ([SourceId]
           ,[Version]
           ,[Timestamp]
           ,[Type]
           ,[Data])
     VALUES
           (@SourceId
           ,@Version
           ,@Timestamp
           ,@Type
           ,@Data)";

        public const string GetEventsSql = @"
SELECT [SourceId]
      ,[Version]
      ,[Timestamp]
      ,[Type]
      ,[Data]
  FROM [EventStore].[dbo].[Events]
  WHERE [SourceId] = @SourceId 
  AND [Version] > @SkipVersion 
";

        public const string InsertSnapshotSql = @"
INSERT INTO [EventStore].[dbo].[Snapshots]
           ([SourceId]
           ,[Version]
           ,[Timestamp]
           ,[Type]
           ,[Data])
     VALUES
           (@SourceId
           ,@Version
           ,@Timestamp
           ,@Type
           ,@Data)";

        public const string GetSnapshotSql = @"
SELECT TOP 1 
       [SourceId]
      ,[Version]
      ,[Timestamp]
      ,[Type]
      ,[Data]
  FROM [EventStore].[dbo].[Snapshots]
  WHERE [SourceId] = @SourceId
  ORDER BY [Version] DESC
";
    }
}