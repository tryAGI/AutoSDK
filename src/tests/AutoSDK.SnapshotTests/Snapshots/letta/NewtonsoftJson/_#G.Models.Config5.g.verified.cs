//HintName: G.Models.Config5.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Config5 : global::System.IEquatable<Config5>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1? SlackChannelReader { get; init; }
#else
        public global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1? SlackChannelReader { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackChannelReader))]
#endif
        public bool IsSlackChannelReader => SlackChannelReader != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2? CustomWebhook { get; init; }
#else
        public global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2? CustomWebhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomWebhook))]
#endif
        public bool IsCustomWebhook => CustomWebhook != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config5(global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1 value) => new Config5((global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1?(Config5 @this) => @this.SlackChannelReader;

        /// <summary>
        /// 
        /// </summary>
        public Config5(global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1? value)
        {
            SlackChannelReader = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config5(global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2 value) => new Config5((global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2?(Config5 @this) => @this.CustomWebhook;

        /// <summary>
        /// 
        /// </summary>
        public Config5(global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2? value)
        {
            CustomWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Config5(
            global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1? slackChannelReader,
            global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2? customWebhook
            )
        {
            SlackChannelReader = slackChannelReader;
            CustomWebhook = customWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomWebhook as object ??
            SlackChannelReader as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SlackChannelReader?.ToString() ??
            CustomWebhook?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSlackChannelReader && !IsCustomWebhook || !IsSlackChannelReader && IsCustomWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1?, TResult>? slackChannelReader = null,
            global::System.Func<global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2?, TResult>? customWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlackChannelReader && slackChannelReader != null)
            {
                return slackChannelReader(SlackChannelReader!);
            }
            else if (IsCustomWebhook && customWebhook != null)
            {
                return customWebhook(CustomWebhook!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1?>? slackChannelReader = null,
            global::System.Action<global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2?>? customWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlackChannelReader)
            {
                slackChannelReader?.Invoke(SlackChannelReader!);
            }
            else if (IsCustomWebhook)
            {
                customWebhook?.Invoke(CustomWebhook!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SlackChannelReader,
                typeof(global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1),
                CustomWebhook,
                typeof(global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2),
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
        public bool Equals(Config5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PipelinesCreatePipelineResponsePipelineConfigVariant1?>.Default.Equals(SlackChannelReader, other.SlackChannelReader) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PipelinesCreatePipelineResponsePipelineConfigVariant2?>.Default.Equals(CustomWebhook, other.CustomWebhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Config5 obj1, Config5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Config5 obj1, Config5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config5 o && Equals(o);
        }
    }
}
