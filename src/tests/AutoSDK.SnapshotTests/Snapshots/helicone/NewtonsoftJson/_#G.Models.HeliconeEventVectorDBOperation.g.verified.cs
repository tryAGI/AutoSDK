//HintName: G.Models.HeliconeEventVectorDBOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HeliconeEventVectorDBOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="insert")]
        Insert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search")]
        Search,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update")]
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeliconeEventVectorDBOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeliconeEventVectorDBOperation value)
        {
            return value switch
            {
                HeliconeEventVectorDBOperation.Delete => "delete",
                HeliconeEventVectorDBOperation.Insert => "insert",
                HeliconeEventVectorDBOperation.Search => "search",
                HeliconeEventVectorDBOperation.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeliconeEventVectorDBOperation? ToEnum(string value)
        {
            return value switch
            {
                "delete" => HeliconeEventVectorDBOperation.Delete,
                "insert" => HeliconeEventVectorDBOperation.Insert,
                "search" => HeliconeEventVectorDBOperation.Search,
                "update" => HeliconeEventVectorDBOperation.Update,
                _ => null,
            };
        }
    }
}