//HintName: G.Models.AssetResponseAttributesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the asset. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`importing` - the asset is being copied to the hosting service&lt;/li&gt;<br/>
    ///   &lt;li&gt;`ready` - the asset is ready to be served to users&lt;/li&gt;<br/>
    ///   &lt;li&gt;`failed` - the asset failed to copy or delete&lt;/li&gt;<br/>
    ///   &lt;li&gt;`deleted` - the asset has been deleted&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: ready
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetResponseAttributesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleted")]
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="importing")]
        Importing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetResponseAttributesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetResponseAttributesStatus value)
        {
            return value switch
            {
                AssetResponseAttributesStatus.Deleted => "deleted",
                AssetResponseAttributesStatus.Failed => "failed",
                AssetResponseAttributesStatus.Importing => "importing",
                AssetResponseAttributesStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetResponseAttributesStatus? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => AssetResponseAttributesStatus.Deleted,
                "failed" => AssetResponseAttributesStatus.Failed,
                "importing" => AssetResponseAttributesStatus.Importing,
                "ready" => AssetResponseAttributesStatus.Ready,
                _ => null,
            };
        }
    }
}