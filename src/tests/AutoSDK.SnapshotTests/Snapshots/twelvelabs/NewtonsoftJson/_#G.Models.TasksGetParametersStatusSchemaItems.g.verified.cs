//HintName: G.Models.TasksGetParametersStatusSchemaItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TasksGetParametersStatusSchemaItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="indexing")]
        Indexing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploading")]
        Uploading,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksGetParametersStatusSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksGetParametersStatusSchemaItems value)
        {
            return value switch
            {
                TasksGetParametersStatusSchemaItems.Failed => "failed",
                TasksGetParametersStatusSchemaItems.Indexing => "indexing",
                TasksGetParametersStatusSchemaItems.Pending => "pending",
                TasksGetParametersStatusSchemaItems.Queued => "queued",
                TasksGetParametersStatusSchemaItems.Ready => "ready",
                TasksGetParametersStatusSchemaItems.Uploading => "uploading",
                TasksGetParametersStatusSchemaItems.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksGetParametersStatusSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "failed" => TasksGetParametersStatusSchemaItems.Failed,
                "indexing" => TasksGetParametersStatusSchemaItems.Indexing,
                "pending" => TasksGetParametersStatusSchemaItems.Pending,
                "queued" => TasksGetParametersStatusSchemaItems.Queued,
                "ready" => TasksGetParametersStatusSchemaItems.Ready,
                "uploading" => TasksGetParametersStatusSchemaItems.Uploading,
                "validating" => TasksGetParametersStatusSchemaItems.Validating,
                _ => null,
            };
        }
    }
}