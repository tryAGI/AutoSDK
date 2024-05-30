//HintName: G.Models.ListFineTuningJobCheckpointsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListFineTuningJobCheckpointsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    public static class ListFineTuningJobCheckpointsResponseObjectExtensions
    {
        public static string ToValueString(this ListFineTuningJobCheckpointsResponseObject value)
        {
            return value switch
            {
                ListFineTuningJobCheckpointsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListFineTuningJobCheckpointsResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => ListFineTuningJobCheckpointsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListFineTuningJobCheckpointsResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => ListFineTuningJobCheckpointsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}