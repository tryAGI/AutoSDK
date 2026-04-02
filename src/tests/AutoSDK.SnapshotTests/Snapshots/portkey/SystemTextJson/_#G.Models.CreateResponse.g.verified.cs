//HintName: G.Models.CreateResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateResponse : global::System.IEquatable<CreateResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateModelResponseProperties? ModelProperties { get; init; }
#else
        public global::G.CreateModelResponseProperties? ModelProperties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelProperties))]
#endif
        public bool IsModelProperties => ModelProperties != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseProperties? Properties { get; init; }
#else
        public global::G.ResponseProperties? Properties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Properties))]
#endif
        public bool IsProperties => Properties != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateResponseVariant3? CreateResponseVariant3 { get; init; }
#else
        public global::G.CreateResponseVariant3? CreateResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateResponseVariant3))]
#endif
        public bool IsCreateResponseVariant3 => CreateResponseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateResponse(global::G.CreateModelResponseProperties value) => new CreateResponse((global::G.CreateModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateModelResponseProperties?(CreateResponse @this) => @this.ModelProperties;

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(global::G.CreateModelResponseProperties? value)
        {
            ModelProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateResponse(global::G.ResponseProperties value) => new CreateResponse((global::G.ResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseProperties?(CreateResponse @this) => @this.Properties;

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(global::G.ResponseProperties? value)
        {
            Properties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateResponse(global::G.CreateResponseVariant3 value) => new CreateResponse((global::G.CreateResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateResponseVariant3?(CreateResponse @this) => @this.CreateResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(global::G.CreateResponseVariant3? value)
        {
            CreateResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(
            global::G.CreateModelResponseProperties? modelProperties,
            global::G.ResponseProperties? properties,
            global::G.CreateResponseVariant3? createResponseVariant3
            )
        {
            ModelProperties = modelProperties;
            Properties = properties;
            CreateResponseVariant3 = createResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateResponseVariant3 as object ??
            Properties as object ??
            ModelProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelProperties?.ToString() ??
            Properties?.ToString() ??
            CreateResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelProperties && IsProperties && IsCreateResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateModelResponseProperties?, TResult>? modelProperties = null,
            global::System.Func<global::G.ResponseProperties?, TResult>? properties = null,
            global::System.Func<global::G.CreateResponseVariant3?, TResult>? createResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelProperties && modelProperties != null)
            {
                return modelProperties(ModelProperties!);
            }
            else if (IsProperties && properties != null)
            {
                return properties(Properties!);
            }
            else if (IsCreateResponseVariant3 && createResponseVariant3 != null)
            {
                return createResponseVariant3(CreateResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateModelResponseProperties?>? modelProperties = null,
            global::System.Action<global::G.ResponseProperties?>? properties = null,
            global::System.Action<global::G.CreateResponseVariant3?>? createResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelProperties)
            {
                modelProperties?.Invoke(ModelProperties!);
            }
            else if (IsProperties)
            {
                properties?.Invoke(Properties!);
            }
            else if (IsCreateResponseVariant3)
            {
                createResponseVariant3?.Invoke(CreateResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelProperties,
                typeof(global::G.CreateModelResponseProperties),
                Properties,
                typeof(global::G.ResponseProperties),
                CreateResponseVariant3,
                typeof(global::G.CreateResponseVariant3),
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
        public bool Equals(CreateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateModelResponseProperties?>.Default.Equals(ModelProperties, other.ModelProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseProperties?>.Default.Equals(Properties, other.Properties) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateResponseVariant3?>.Default.Equals(CreateResponseVariant3, other.CreateResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateResponse obj1, CreateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateResponse obj1, CreateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateResponse o && Equals(o);
        }
    }
}
