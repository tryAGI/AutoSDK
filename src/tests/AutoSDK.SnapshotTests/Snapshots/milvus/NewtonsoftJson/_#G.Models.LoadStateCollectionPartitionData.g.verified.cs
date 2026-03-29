//HintName: G.Models.LoadStateCollectionPartitionData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoadStateCollectionPartitionData
    {
        /// <summary>
        /// An object that indicates the load status of the specified collection.<br/>
        /// The possible states are as follows:<br/>
        /// - **Loaded**<br/>
        ///   -  Indicates that the specified collection is loaded.<br/>
        /// - **Loading**<br/>
        ///   -  Indicates that the specified collection is being loaded.<br/>
        /// - **NotExist**<br/>
        ///   -  Indicates that the specified collection does not exist. <br/>
        ///   -  Including a non-existing partition in **partition_names** results in a **MilvusException**.<br/>
        /// - **NotLoad**<br/>
        ///   -  Indicates that the specified collection is not loaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loadState", Required = global::Newtonsoft.Json.Required.Always)]
        public string LoadState { get; set; } = default!;

        /// <summary>
        /// An integer that indicates the load progress in the percentage of the specified collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loadProgress", Required = global::Newtonsoft.Json.Required.Always)]
        public int LoadProgress { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadStateCollectionPartitionData" /> class.
        /// </summary>
        /// <param name="loadState">
        /// An object that indicates the load status of the specified collection.<br/>
        /// The possible states are as follows:<br/>
        /// - **Loaded**<br/>
        ///   -  Indicates that the specified collection is loaded.<br/>
        /// - **Loading**<br/>
        ///   -  Indicates that the specified collection is being loaded.<br/>
        /// - **NotExist**<br/>
        ///   -  Indicates that the specified collection does not exist. <br/>
        ///   -  Including a non-existing partition in **partition_names** results in a **MilvusException**.<br/>
        /// - **NotLoad**<br/>
        ///   -  Indicates that the specified collection is not loaded.
        /// </param>
        /// <param name="loadProgress">
        /// An integer that indicates the load progress in the percentage of the specified collection.
        /// </param>
        public LoadStateCollectionPartitionData(
            string loadState,
            int loadProgress)
        {
            this.LoadState = loadState ?? throw new global::System.ArgumentNullException(nameof(loadState));
            this.LoadProgress = loadProgress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadStateCollectionPartitionData" /> class.
        /// </summary>
        public LoadStateCollectionPartitionData()
        {
        }
    }
}