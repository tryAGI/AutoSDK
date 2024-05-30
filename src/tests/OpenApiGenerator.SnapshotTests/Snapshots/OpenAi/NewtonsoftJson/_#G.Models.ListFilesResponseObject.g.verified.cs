//HintName: G.Models.ListFilesResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListFilesResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    public static class ListFilesResponseObjectExtensions
    {
        public static string ToValueString(this ListFilesResponseObject value)
        {
            return value switch
            {
                ListFilesResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListFilesResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => ListFilesResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListFilesResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => ListFilesResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}