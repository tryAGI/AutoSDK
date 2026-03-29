//HintName: G.Models.ShardTransferMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Methods for transferring a shard from one node to another.<br/>
    /// - `stream_records` - Stream all shard records in batches until the whole shard is transferred.<br/>
    /// - `snapshot` - Snapshot the shard, transfer and restore it on the receiver.<br/>
    /// - `wal_delta` - Attempt to transfer shard difference by WAL delta.<br/>
    /// - `resharding_stream_records` - Shard transfer for resharding: stream all records in batches until all points are transferred.
    /// </summary>
    public enum ShardTransferMethod
    {
        /// <summary>
        /// stream all records in batches until all points are transferred.
        /// </summary>
        ReshardingStreamRecords,
        /// <summary>
        /// 
        /// </summary>
        Snapshot,
        /// <summary>
        /// stream all records in batches until all points are transferred.
        /// </summary>
        StreamRecords,
        /// <summary>
        /// 
        /// </summary>
        WalDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShardTransferMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShardTransferMethod value)
        {
            return value switch
            {
                ShardTransferMethod.ReshardingStreamRecords => "resharding_stream_records",
                ShardTransferMethod.Snapshot => "snapshot",
                ShardTransferMethod.StreamRecords => "stream_records",
                ShardTransferMethod.WalDelta => "wal_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShardTransferMethod? ToEnum(string value)
        {
            return value switch
            {
                "resharding_stream_records" => ShardTransferMethod.ReshardingStreamRecords,
                "snapshot" => ShardTransferMethod.Snapshot,
                "stream_records" => ShardTransferMethod.StreamRecords,
                "wal_delta" => ShardTransferMethod.WalDelta,
                _ => null,
            };
        }
    }
}