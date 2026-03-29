//HintName: G.Models.TransferResponseAttributesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the asset transfer. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`queued` - the transfer request has been queued&lt;/li&gt;<br/>
    ///   &lt;li&gt;`failed` - the transfer request failed&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: queued
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferResponseAttributesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferResponseAttributesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferResponseAttributesStatus value)
        {
            return value switch
            {
                TransferResponseAttributesStatus.Failed => "failed",
                TransferResponseAttributesStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferResponseAttributesStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => TransferResponseAttributesStatus.Failed,
                "queued" => TransferResponseAttributesStatus.Queued,
                _ => null,
            };
        }
    }
}