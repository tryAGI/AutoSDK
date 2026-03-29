//HintName: G.Models.UploadDatasetRequestAction2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UploadDatasetRequestAction2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="append")]
        Append,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create")]
        Create,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadDatasetRequestAction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadDatasetRequestAction2 value)
        {
            return value switch
            {
                UploadDatasetRequestAction2.Append => "append",
                UploadDatasetRequestAction2.Create => "create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadDatasetRequestAction2? ToEnum(string value)
        {
            return value switch
            {
                "append" => UploadDatasetRequestAction2.Append,
                "create" => UploadDatasetRequestAction2.Create,
                _ => null,
            };
        }
    }
}