﻿//HintName: G.Models.DataItem.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem : global::System.IEquatable<DataItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelListDataItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseModelCard? BaseModelCard { get; init; }
#else
        public global::G.BaseModelCard? BaseModelCard { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseModelCard))]
#endif
        public bool IsBaseModelCard => BaseModelCard != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::G.BaseModelCard value) => new DataItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseModelCard?(DataItem @this) => @this.BaseModelCard;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::G.BaseModelCard? value)
        {
            BaseModelCard = value;
        }

        /// <summary>
        /// Extra fields for fine-tuned models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FTModelCard? FTModelCard { get; init; }
#else
        public global::G.FTModelCard? FTModelCard { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FTModelCard))]
#endif
        public bool IsFTModelCard => FTModelCard != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::G.FTModelCard value) => new DataItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FTModelCard?(DataItem @this) => @this.FTModelCard;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::G.FTModelCard? value)
        {
            FTModelCard = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem(
            global::G.ModelListDataItemDiscriminatorType? type,
            global::G.BaseModelCard? baseModelCard,
            global::G.FTModelCard? fTModelCard
            )
        {
            Type = type;

            BaseModelCard = baseModelCard;
            FTModelCard = fTModelCard;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FTModelCard as object ??
            BaseModelCard as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseModelCard && !IsFTModelCard || !IsBaseModelCard && IsFTModelCard;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseModelCard?, TResult>? baseModelCard = null,
            global::System.Func<global::G.FTModelCard?, TResult>? fTModelCard = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseModelCard && baseModelCard != null)
            {
                return baseModelCard(BaseModelCard!);
            }
            else if (IsFTModelCard && fTModelCard != null)
            {
                return fTModelCard(FTModelCard!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseModelCard?>? baseModelCard = null,
            global::System.Action<global::G.FTModelCard?>? fTModelCard = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseModelCard)
            {
                baseModelCard?.Invoke(BaseModelCard!);
            }
            else if (IsFTModelCard)
            {
                fTModelCard?.Invoke(FTModelCard!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseModelCard,
                typeof(global::G.BaseModelCard),
                FTModelCard,
                typeof(global::G.FTModelCard),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(DataItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseModelCard?>.Default.Equals(BaseModelCard, other.BaseModelCard) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FTModelCard?>.Default.Equals(FTModelCard, other.FTModelCard) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem obj1, DataItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem obj1, DataItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.DataItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.DataItem),
                jsonSerializerContext) as global::G.DataItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DataItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
