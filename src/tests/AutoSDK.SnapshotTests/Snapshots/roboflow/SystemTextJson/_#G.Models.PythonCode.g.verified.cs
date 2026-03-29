//HintName: G.Models.PythonCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PythonCode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"PythonCode"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "PythonCode";

        /// <summary>
        /// Code of python function. Content should be properly formatted including indentations. Workflows execution engine is to create dynamic module with provided function - ensuring imports of the following symbols: [Any, List, Dict, Set, sv, np, math, time, json, os, requests, cv2, shapely, Batch, WorkflowImageData, BlockResult]. Expected signature is: def run(self, ... # parameters of manifest apart from name and type). Through self, one may access self._init_results which is dict returned by `init_code` if given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_function_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunFunctionCode { get; set; }

        /// <summary>
        /// Name of the function shipped in `function_code`.<br/>
        /// Default Value: run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_function_name")]
        public string? RunFunctionName { get; set; }

        /// <summary>
        /// Code of the function to perform initialisation of the block. It must be parameter-free function with signature `def init() -&gt; Dict[str, Any]` setting self._init_results on dynamic class initialisation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_function_code")]
        public string? InitFunctionCode { get; set; }

        /// <summary>
        /// Name of init_code function.<br/>
        /// Default Value: init
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_function_name")]
        public string? InitFunctionName { get; set; }

        /// <summary>
        /// List of additional imports required to run the code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imports")]
        public global::System.Collections.Generic.IList<string>? Imports { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonCode" /> class.
        /// </summary>
        /// <param name="runFunctionCode">
        /// Code of python function. Content should be properly formatted including indentations. Workflows execution engine is to create dynamic module with provided function - ensuring imports of the following symbols: [Any, List, Dict, Set, sv, np, math, time, json, os, requests, cv2, shapely, Batch, WorkflowImageData, BlockResult]. Expected signature is: def run(self, ... # parameters of manifest apart from name and type). Through self, one may access self._init_results which is dict returned by `init_code` if given.
        /// </param>
        /// <param name="runFunctionName">
        /// Name of the function shipped in `function_code`.<br/>
        /// Default Value: run
        /// </param>
        /// <param name="initFunctionCode">
        /// Code of the function to perform initialisation of the block. It must be parameter-free function with signature `def init() -&gt; Dict[str, Any]` setting self._init_results on dynamic class initialisation
        /// </param>
        /// <param name="initFunctionName">
        /// Name of init_code function.<br/>
        /// Default Value: init
        /// </param>
        /// <param name="imports">
        /// List of additional imports required to run the code
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PythonCode(
            string runFunctionCode,
            string? runFunctionName,
            string? initFunctionCode,
            string? initFunctionName,
            global::System.Collections.Generic.IList<string>? imports,
            string type = "PythonCode")
        {
            this.Type = type;
            this.RunFunctionCode = runFunctionCode ?? throw new global::System.ArgumentNullException(nameof(runFunctionCode));
            this.RunFunctionName = runFunctionName;
            this.InitFunctionCode = initFunctionCode;
            this.InitFunctionName = initFunctionName;
            this.Imports = imports;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonCode" /> class.
        /// </summary>
        public PythonCode()
        {
        }
    }
}