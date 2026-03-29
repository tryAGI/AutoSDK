//HintName: G.Models.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Indexing,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems value)
        {
            return value switch
            {
                IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Failed => "failed",
                IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Indexing => "indexing",
                IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Pending => "pending",
                IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Queued => "queued",
                IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "failed" => IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Failed,
                "indexing" => IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Indexing,
                "pending" => IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Pending,
                "queued" => IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Queued,
                "ready" => IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems.Ready,
                _ => null,
            };
        }
    }
}