//HintName: G.Models.CreateLambdaToolRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a new lambda tool. Lambda tools are user-defined functions that run in a secure, sandboxed environment with Python 3.12.<br/>
    /// Input and output schemas are automatically discovered from function parameter type annotations in your code.
    /// </summary>
    public sealed partial class CreateLambdaToolRequest
    {
        /// <summary>
        /// This should always be `lambda`.<br/>
        /// Default Value: lambda<br/>
        /// Example: lambda
        /// </summary>
        /// <default>"lambda"</default>
        /// <example>lambda</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The unique name of the tool (used as the function identifier).<br/>
        /// Example: calculate_customer_score
        /// </summary>
        /// <example>calculate_customer_score</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Human-readable title of the tool displayed in the UI.<br/>
        /// Example: Customer Score Calculator
        /// </summary>
        /// <example>Customer Score Calculator</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A detailed description of what the function does, when to use it, and what it returns.<br/>
        /// Example: Calculate a customer score based on order history and revenue. Returns a score between 0-100.
        /// </summary>
        /// <example>Calculate a customer score based on order history and revenue. Returns a score between 0-100.</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The programming language. Currently only 'python' (Python 3.12) is supported.<br/>
        /// Default Value: python<br/>
        /// Example: python
        /// </summary>
        /// <example>python</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.CreateLambdaToolRequestLanguage? Language { get; set; }

        /// <summary>
        /// The Python 3.12 code for the function.<br/>
        /// **Required**: Must define a `process()` entry point function. Use type annotations on parameters for automatic schema discovery.<br/>
        /// **Parameters**: Passed as keyword arguments matched to the function signature.<br/>
        /// **Return types**: Can return any JSON-serializable type (strings, numbers, booleans, lists, or objects).<br/>
        /// **Parameter Descriptions**: Use docstrings to provide descriptions for parameters (Google, NumPy, ReST, and Epydoc styles are supported). These descriptions are automatically extracted and included in the input schema, giving agents better context about how to use each parameter.<br/>
        /// **Example with Google-style docstring:**<br/>
        /// ```python<br/>
        /// def process(order_count: int, total_revenue: float, days_active: int = 1) -&gt; dict:<br/>
        ///     """Calculate customer engagement score.<br/>
        ///     Args:<br/>
        ///         order_count: The number of orders placed by the customer.<br/>
        ///         total_revenue: Total revenue in USD from the customer.<br/>
        ///         days_active: Number of days the customer was active (default: 1).<br/>
        ///     Returns:<br/>
        ///         A dict with the calculated score.<br/>
        ///     """<br/>
        ///     score = (order_count * 10 + total_revenue * 0.1) / days_active<br/>
        ///     return {'score': round(score, 2)}<br/>
        /// ```<br/>
        /// This produces an input schema with descriptions:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "order_count": {<br/>
        ///       "type": "integer",<br/>
        ///       "description": "The number of orders placed by the customer."<br/>
        ///     },<br/>
        ///     "total_revenue": {<br/>
        ///       "type": "number",<br/>
        ///       "description": "Total revenue in USD from the customer."<br/>
        ///     },<br/>
        ///     "days_active": {<br/>
        ///       "type": "integer",<br/>
        ///       "description": "Number of days the customer was active (default: 1)."<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "required": ["order_count", "total_revenue"]<br/>
        /// }<br/>
        /// ```<br/>
        /// **Example: Returning a number**<br/>
        /// ```python<br/>
        /// def process(x: int, y: int) -&gt; int:<br/>
        ///     return x + y<br/>
        /// ```<br/>
        /// **Example: Returning a string**<br/>
        /// ```python<br/>
        /// def process(name: str) -&gt; str:<br/>
        ///     return f"Hello, {name}!"<br/>
        /// ```<br/>
        /// **Example: Returning a boolean**<br/>
        /// ```python<br/>
        /// def process(value: int, threshold: int) -&gt; bool:<br/>
        ///     return value &gt; threshold<br/>
        /// ```<br/>
        /// **Example: Returning a list**<br/>
        /// ```python<br/>
        /// from typing import List<br/>
        /// def process(items: List[str]) -&gt; List[str]:<br/>
        ///     return sorted(items)<br/>
        /// ```<br/>
        /// **Example: Returning an object (dict)**<br/>
        /// ```python<br/>
        /// def process(order_count: int, total_revenue: float, days_active: int = 1) -&gt; dict:<br/>
        ///     score = (order_count * 10 + total_revenue * 0.1) / days_active<br/>
        ///     return {'score': round(score, 2), 'rating': 'high' if score &gt; 100 else 'low'}<br/>
        /// ```<br/>
        /// For complex types, use the `typing` module:<br/>
        /// ```python<br/>
        /// from typing import List<br/>
        /// def process(items: List[str], count: int) -&gt; dict:<br/>
        ///     return {'total': len(items) * count}<br/>
        /// ```<br/>
        /// **Object parameters must use TypedDict**: Bare `dict` and `Dict[K, V]` parameters are not supported and will be rejected during validation. All object-typed parameters must use `TypedDict` to define explicit fields. This ensures the agent receives a clear schema for each parameter.<br/>
        /// ```python<br/>
        /// from typing import TypedDict, Optional<br/>
        /// class Adjustment(TypedDict, total=False):<br/>
        ///     monthly_premium: float<br/>
        ///     target_income_age: int<br/>
        ///     illustrated_rate: float<br/>
        /// def process(client_id: str, adjustment: Adjustment) -&gt; dict:<br/>
        ///     return {"client_id": client_id, "adjustment": adjustment}<br/>
        /// ```<br/>
        /// TypedDict supports inheritance, `Optional` fields, nested TypedDicts, and `total=False` to make all fields optional.<br/>
        /// Example: def process(order_count: int, total_revenue: float, days_active: int = 1) -&gt; dict:<br/>
        ///     score = (order_count * 10 + total_revenue * 0.1) / days_active<br/>
        ///     return {'score': round(score, 2)}
        /// </summary>
        /// <example>
        /// def process(order_count: int, total_revenue: float, days_active: int = 1) -&gt; dict:<br/>
        ///     score = (order_count * 10 + total_revenue * 0.1) / days_active<br/>
        ///     return {'score': round(score, 2)}
        /// </example>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Execution configuration for the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_configuration")]
        public global::G.ExecutionConfiguration? ExecutionConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLambdaToolRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `lambda`.<br/>
        /// Default Value: lambda<br/>
        /// Example: lambda
        /// </param>
        /// <param name="name">
        /// The unique name of the tool (used as the function identifier).<br/>
        /// Example: calculate_customer_score
        /// </param>
        /// <param name="title">
        /// Human-readable title of the tool displayed in the UI.<br/>
        /// Example: Customer Score Calculator
        /// </param>
        /// <param name="description">
        /// A detailed description of what the function does, when to use it, and what it returns.<br/>
        /// Example: Calculate a customer score based on order history and revenue. Returns a score between 0-100.
        /// </param>
        /// <param name="language">
        /// The programming language. Currently only 'python' (Python 3.12) is supported.<br/>
        /// Default Value: python<br/>
        /// Example: python
        /// </param>
        /// <param name="code">
        /// The Python 3.12 code for the function.<br/>
        /// **Required**: Must define a `process()` entry point function. Use type annotations on parameters for automatic schema discovery.<br/>
        /// **Parameters**: Passed as keyword arguments matched to the function signature.<br/>
        /// **Return types**: Can return any JSON-serializable type (strings, numbers, booleans, lists, or objects).<br/>
        /// **Parameter Descriptions**: Use docstrings to provide descriptions for parameters (Google, NumPy, ReST, and Epydoc styles are supported). These descriptions are automatically extracted and included in the input schema, giving agents better context about how to use each parameter.<br/>
        /// **Example with Google-style docstring:**<br/>
        /// ```python<br/>
        /// def process(order_count: int, total_revenue: float, days_active: int = 1) -&gt; dict:<br/>
        ///     """Calculate customer engagement score.<br/>
        ///     Args:<br/>
        ///         order_count: The number of orders placed by the customer.<br/>
        ///         total_revenue: Total revenue in USD from the customer.<br/>
        ///         days_active: Number of days the customer was active (default: 1).<br/>
        ///     Returns:<br/>
        ///         A dict with the calculated score.<br/>
        ///     """<br/>
        ///     score = (order_count * 10 + total_revenue * 0.1) / days_active<br/>
        ///     return {'score': round(score, 2)}<br/>
        /// ```<br/>
        /// This produces an input schema with descriptions:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "order_count": {<br/>
        ///       "type": "integer",<br/>
        ///       "description": "The number of orders placed by the customer."<br/>
        ///     },<br/>
        ///     "total_revenue": {<br/>
        ///       "type": "number",<br/>
        ///       "description": "Total revenue in USD from the customer."<br/>
        ///     },<br/>
        ///     "days_active": {<br/>
        ///       "type": "integer",<br/>
        ///       "description": "Number of days the customer was active (default: 1)."<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "required": ["order_count", "total_revenue"]<br/>
        /// }<br/>
        /// ```<br/>
        /// **Example: Returning a number**<br/>
        /// ```python<br/>
        /// def process(x: int, y: int) -&gt; int:<br/>
        ///     return x + y<br/>
        /// ```<br/>
        /// **Example: Returning a string**<br/>
        /// ```python<br/>
        /// def process(name: str) -&gt; str:<br/>
        ///     return f"Hello, {name}!"<br/>
        /// ```<br/>
        /// **Example: Returning a boolean**<br/>
        /// ```python<br/>
        /// def process(value: int, threshold: int) -&gt; bool:<br/>
        ///     return value &gt; threshold<br/>
        /// ```<br/>
        /// **Example: Returning a list**<br/>
        /// ```python<br/>
        /// from typing import List<br/>
        /// def process(items: List[str]) -&gt; List[str]:<br/>
        ///     return sorted(items)<br/>
        /// ```<br/>
        /// **Example: Returning an object (dict)**<br/>
        /// ```python<br/>
        /// def process(order_count: int, total_revenue: float, days_active: int = 1) -&gt; dict:<br/>
        ///     score = (order_count * 10 + total_revenue * 0.1) / days_active<br/>
        ///     return {'score': round(score, 2), 'rating': 'high' if score &gt; 100 else 'low'}<br/>
        /// ```<br/>
        /// For complex types, use the `typing` module:<br/>
        /// ```python<br/>
        /// from typing import List<br/>
        /// def process(items: List[str], count: int) -&gt; dict:<br/>
        ///     return {'total': len(items) * count}<br/>
        /// ```<br/>
        /// **Object parameters must use TypedDict**: Bare `dict` and `Dict[K, V]` parameters are not supported and will be rejected during validation. All object-typed parameters must use `TypedDict` to define explicit fields. This ensures the agent receives a clear schema for each parameter.<br/>
        /// ```python<br/>
        /// from typing import TypedDict, Optional<br/>
        /// class Adjustment(TypedDict, total=False):<br/>
        ///     monthly_premium: float<br/>
        ///     target_income_age: int<br/>
        ///     illustrated_rate: float<br/>
        /// def process(client_id: str, adjustment: Adjustment) -&gt; dict:<br/>
        ///     return {"client_id": client_id, "adjustment": adjustment}<br/>
        /// ```<br/>
        /// TypedDict supports inheritance, `Optional` fields, nested TypedDicts, and `total=False` to make all fields optional.<br/>
        /// Example: def process(order_count: int, total_revenue: float, days_active: int = 1) -&gt; dict:<br/>
        ///     score = (order_count * 10 + total_revenue * 0.1) / days_active<br/>
        ///     return {'score': round(score, 2)}
        /// </param>
        /// <param name="executionConfiguration">
        /// Execution configuration for the function.
        /// </param>
        public CreateLambdaToolRequest(
            string type,
            string name,
            string title,
            string description,
            string code,
            global::G.CreateLambdaToolRequestLanguage? language,
            global::G.ExecutionConfiguration? executionConfiguration)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Language = language;
            this.ExecutionConfiguration = executionConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLambdaToolRequest" /> class.
        /// </summary>
        public CreateLambdaToolRequest()
        {
        }
    }
}