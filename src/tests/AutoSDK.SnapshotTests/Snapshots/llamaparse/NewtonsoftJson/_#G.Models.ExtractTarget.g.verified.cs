//HintName: G.Models.ExtractTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the extraction target scope.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PER_DOC")]
        PerDoc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PER_PAGE")]
        PerPage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PER_TABLE_ROW")]
        PerTableRow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractTarget value)
        {
            return value switch
            {
                ExtractTarget.PerDoc => "PER_DOC",
                ExtractTarget.PerPage => "PER_PAGE",
                ExtractTarget.PerTableRow => "PER_TABLE_ROW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractTarget? ToEnum(string value)
        {
            return value switch
            {
                "PER_DOC" => ExtractTarget.PerDoc,
                "PER_PAGE" => ExtractTarget.PerPage,
                "PER_TABLE_ROW" => ExtractTarget.PerTableRow,
                _ => null,
            };
        }
    }
}