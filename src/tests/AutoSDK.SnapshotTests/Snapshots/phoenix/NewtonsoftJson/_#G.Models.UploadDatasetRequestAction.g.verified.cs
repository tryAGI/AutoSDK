//HintName: G.Models.UploadDatasetRequestAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UploadDatasetRequestAction
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
    public static class UploadDatasetRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadDatasetRequestAction value)
        {
            return value switch
            {
                UploadDatasetRequestAction.Append => "append",
                UploadDatasetRequestAction.Create => "create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadDatasetRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "append" => UploadDatasetRequestAction.Append,
                "create" => UploadDatasetRequestAction.Create,
                _ => null,
            };
        }
    }
}