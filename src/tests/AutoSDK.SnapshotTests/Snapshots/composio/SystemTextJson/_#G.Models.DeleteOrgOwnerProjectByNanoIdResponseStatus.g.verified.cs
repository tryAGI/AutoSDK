//HintName: G.Models.DeleteOrgOwnerProjectByNanoIdResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status indicating successful deletion<br/>
    /// Example: success
    /// </summary>
    public enum DeleteOrgOwnerProjectByNanoIdResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteOrgOwnerProjectByNanoIdResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteOrgOwnerProjectByNanoIdResponseStatus value)
        {
            return value switch
            {
                DeleteOrgOwnerProjectByNanoIdResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteOrgOwnerProjectByNanoIdResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => DeleteOrgOwnerProjectByNanoIdResponseStatus.Success,
                _ => null,
            };
        }
    }
}