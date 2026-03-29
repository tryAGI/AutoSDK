//HintName: G.Models.ToolChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configure how the model will call functions:<br/>
    /// - `auto`: allows the model to automatically choose the tool to use, or not call a tool<br/>
    /// - `none`: disables tool calling; the model will instead generate a message<br/>
    /// - `required`: requires the model to call one or more tools<br/>
    /// You can also use a JSON object to force the model to call a specific tool. For example, `{"type": "function", "function": {"name": "get_current_weather"}}` requires the model to call the `get_current_weather` function, regardless of the prompt.
    /// </summary>
    public readonly partial struct ToolChoice : global::System.IEquatable<ToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StringToolChoice? String { get; init; }
#else
        public global::G.StringToolChoice? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.JsonObjectToolChoice? JsonObject { get; init; }
#else
        public global::G.JsonObjectToolChoice? JsonObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonObject))]
#endif
        public bool IsJsonObject => JsonObject != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::G.StringToolChoice value) => new ToolChoice((global::G.StringToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StringToolChoice?(ToolChoice @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::G.StringToolChoice? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::G.JsonObjectToolChoice value) => new ToolChoice((global::G.JsonObjectToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.JsonObjectToolChoice?(ToolChoice @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::G.JsonObjectToolChoice? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(
            global::G.StringToolChoice? @string,
            global::G.JsonObjectToolChoice? jsonObject
            )
        {
            String = @string;
            JsonObject = jsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonObject as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            JsonObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsJsonObject || !IsString && IsJsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StringToolChoice?, TResult>? @string = null,
            global::System.Func<global::G.JsonObjectToolChoice?, TResult>? jsonObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StringToolChoice?>? @string = null,
            global::System.Action<global::G.JsonObjectToolChoice?>? jsonObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::G.StringToolChoice),
                JsonObject,
                typeof(global::G.JsonObjectToolChoice),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StringToolChoice?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::G.JsonObjectToolChoice?>.Default.Equals(JsonObject, other.JsonObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolChoice obj1, ToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolChoice obj1, ToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChoice o && Equals(o);
        }
    }
}
