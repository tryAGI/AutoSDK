//HintName: G.Models.ListFineTuningCheckpointPermissionResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListFineTuningCheckpointPermissionResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFineTuningCheckpointPermissionResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFineTuningCheckpointPermissionResponseObject value)
        {
            return value switch
            {
                ListFineTuningCheckpointPermissionResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFineTuningCheckpointPermissionResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListFineTuningCheckpointPermissionResponseObject.List,
                _ => null,
            };
        }
    }
}