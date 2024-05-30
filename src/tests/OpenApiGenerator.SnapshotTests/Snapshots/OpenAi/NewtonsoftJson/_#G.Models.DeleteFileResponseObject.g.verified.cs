//HintName: G.Models.DeleteFileResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteFileResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
    }

    public static class DeleteFileResponseObjectExtensions
    {
        public static string ToValueString(this DeleteFileResponseObject value)
        {
            return value switch
            {
                DeleteFileResponseObject.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteFileResponseObject ToEnum(string value)
        {
            return value switch
            {
                "file" => DeleteFileResponseObject.File,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteFileResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => DeleteFileResponseObject.File,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}