//HintName: G.Models.OpenAIFileObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `file`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIFileObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
    }

    public static class OpenAIFileObjectExtensions
    {
        public static string ToValueString(this OpenAIFileObject value)
        {
            return value switch
            {
                OpenAIFileObject.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static OpenAIFileObject ToEnum(string value)
        {
            return value switch
            {
                "file" => OpenAIFileObject.File,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static OpenAIFileObject ToEnum(int value)
        {
            return value switch
            {
                0 => OpenAIFileObject.File,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}