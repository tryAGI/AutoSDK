//HintName: G.Models.SupabaseBucketPlanRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the S3 Region. It should look like us-east-1<br/>
    /// It should be one of the supabase regions defined in the SUPABASE_REGION enum<br/>
    /// Check https://supabase.com/docs/guides/platform/regions for up to date regions
    /// </summary>
    public enum SupabaseBucketPlanRegion
    {
        /// <summary>
        /// 
        /// </summary>
        ApNortheast1,
        /// <summary>
        /// 
        /// </summary>
        ApNortheast2,
        /// <summary>
        /// 
        /// </summary>
        ApSouth1,
        /// <summary>
        /// 
        /// </summary>
        ApSoutheast1,
        /// <summary>
        /// 
        /// </summary>
        ApSoutheast2,
        /// <summary>
        /// 
        /// </summary>
        CaCentral1,
        /// <summary>
        /// 
        /// </summary>
        EuCentral1,
        /// <summary>
        /// 
        /// </summary>
        EuCentral2,
        /// <summary>
        /// 
        /// </summary>
        EuNorth1,
        /// <summary>
        /// 
        /// </summary>
        EuWest1,
        /// <summary>
        /// 
        /// </summary>
        EuWest2,
        /// <summary>
        /// 
        /// </summary>
        EuWest3,
        /// <summary>
        /// 
        /// </summary>
        SaEast1,
        /// <summary>
        /// 
        /// </summary>
        UsEast1,
        /// <summary>
        /// 
        /// </summary>
        UsEast2,
        /// <summary>
        /// 
        /// </summary>
        UsWest1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupabaseBucketPlanRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupabaseBucketPlanRegion value)
        {
            return value switch
            {
                SupabaseBucketPlanRegion.ApNortheast1 => "ap-northeast-1",
                SupabaseBucketPlanRegion.ApNortheast2 => "ap-northeast-2",
                SupabaseBucketPlanRegion.ApSouth1 => "ap-south-1",
                SupabaseBucketPlanRegion.ApSoutheast1 => "ap-southeast-1",
                SupabaseBucketPlanRegion.ApSoutheast2 => "ap-southeast-2",
                SupabaseBucketPlanRegion.CaCentral1 => "ca-central-1",
                SupabaseBucketPlanRegion.EuCentral1 => "eu-central-1",
                SupabaseBucketPlanRegion.EuCentral2 => "eu-central-2",
                SupabaseBucketPlanRegion.EuNorth1 => "eu-north-1",
                SupabaseBucketPlanRegion.EuWest1 => "eu-west-1",
                SupabaseBucketPlanRegion.EuWest2 => "eu-west-2",
                SupabaseBucketPlanRegion.EuWest3 => "eu-west-3",
                SupabaseBucketPlanRegion.SaEast1 => "sa-east-1",
                SupabaseBucketPlanRegion.UsEast1 => "us-east-1",
                SupabaseBucketPlanRegion.UsEast2 => "us-east-2",
                SupabaseBucketPlanRegion.UsWest1 => "us-west-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupabaseBucketPlanRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-northeast-1" => SupabaseBucketPlanRegion.ApNortheast1,
                "ap-northeast-2" => SupabaseBucketPlanRegion.ApNortheast2,
                "ap-south-1" => SupabaseBucketPlanRegion.ApSouth1,
                "ap-southeast-1" => SupabaseBucketPlanRegion.ApSoutheast1,
                "ap-southeast-2" => SupabaseBucketPlanRegion.ApSoutheast2,
                "ca-central-1" => SupabaseBucketPlanRegion.CaCentral1,
                "eu-central-1" => SupabaseBucketPlanRegion.EuCentral1,
                "eu-central-2" => SupabaseBucketPlanRegion.EuCentral2,
                "eu-north-1" => SupabaseBucketPlanRegion.EuNorth1,
                "eu-west-1" => SupabaseBucketPlanRegion.EuWest1,
                "eu-west-2" => SupabaseBucketPlanRegion.EuWest2,
                "eu-west-3" => SupabaseBucketPlanRegion.EuWest3,
                "sa-east-1" => SupabaseBucketPlanRegion.SaEast1,
                "us-east-1" => SupabaseBucketPlanRegion.UsEast1,
                "us-east-2" => SupabaseBucketPlanRegion.UsEast2,
                "us-west-1" => SupabaseBucketPlanRegion.UsWest1,
                _ => null,
            };
        }
    }
}