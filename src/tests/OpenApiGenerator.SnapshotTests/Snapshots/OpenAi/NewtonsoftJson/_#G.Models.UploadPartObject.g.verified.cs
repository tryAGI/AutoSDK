//HintName: G.Models.UploadPartObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `upload.part`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UploadPartObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="upload.part")]
        UploadPart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadPartObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadPartObject value)
        {
            return value switch
            {
                UploadPartObject.UploadPart => "upload.part",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadPartObject? ToEnum(string value)
        {
            return value switch
            {
                "upload.part" => UploadPartObject.UploadPart,
                _ => null,
            };
        }
    }
}