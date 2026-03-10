//HintName: G.Models.ListChatResponseTestsRouteSortMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort mode for listing tests. Use 'folders_first' to place folders before tests.<br/>
    /// Default Value: default
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListChatResponseTestsRouteSortMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="folders_first")]
        FoldersFirst,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListChatResponseTestsRouteSortModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListChatResponseTestsRouteSortMode value)
        {
            return value switch
            {
                ListChatResponseTestsRouteSortMode.Default => "default",
                ListChatResponseTestsRouteSortMode.FoldersFirst => "folders_first",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListChatResponseTestsRouteSortMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => ListChatResponseTestsRouteSortMode.Default,
                "folders_first" => ListChatResponseTestsRouteSortMode.FoldersFirst,
                _ => null,
            };
        }
    }
}