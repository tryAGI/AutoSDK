//HintName: G.Models.Config9.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Config9 : global::System.IEquatable<Config9>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1? SlackChannelReader { get; init; }
#else
        public global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1? SlackChannelReader { get; }
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
        public global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2? CustomWebhook { get; init; }
#else
        public global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2? CustomWebhook { get; }
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
        public static implicit operator Config9(global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1 value) => new Config9((global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1?(Config9 @this) => @this.SlackChannelReader;

        /// <summary>
        /// 
        /// </summary>
        public Config9(global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1? value)
        {
            SlackChannelReader = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config9(global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2 value) => new Config9((global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2?(Config9 @this) => @this.CustomWebhook;

        /// <summary>
        /// 
        /// </summary>
        public Config9(global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2? value)
        {
            CustomWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Config9(
            global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1? slackChannelReader,
            global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2? customWebhook
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
            global::System.Func<global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1?, TResult>? slackChannelReader = null,
            global::System.Func<global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2?, TResult>? customWebhook = null,
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
            global::System.Action<global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1?>? slackChannelReader = null,
            global::System.Action<global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2?>? customWebhook = null,
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
                typeof(global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1),
                CustomWebhook,
                typeof(global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2),
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
        public bool Equals(Config9 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1?>.Default.Equals(SlackChannelReader, other.SlackChannelReader) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2?>.Default.Equals(CustomWebhook, other.CustomWebhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Config9 obj1, Config9 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config9>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Config9 obj1, Config9 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config9 o && Equals(o);
        }
    }
}
