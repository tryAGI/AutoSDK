//HintName: G.Models.UploadDatasetRequestAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadDatasetRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
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