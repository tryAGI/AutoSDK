//HintName: G.Models.CodeScanningListRecentAnalysesDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningListRecentAnalysesDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningListRecentAnalysesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListRecentAnalysesDirection value)
        {
            return value switch
            {
                CodeScanningListRecentAnalysesDirection.Asc => "asc",
                CodeScanningListRecentAnalysesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListRecentAnalysesDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => CodeScanningListRecentAnalysesDirection.Asc,
                "desc" => CodeScanningListRecentAnalysesDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}