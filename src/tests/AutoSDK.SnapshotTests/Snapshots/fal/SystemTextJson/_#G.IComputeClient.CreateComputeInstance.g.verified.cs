//HintName: G.IComputeClient.CreateComputeInstance.g.cs
#nullable enable

namespace G
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Create Compute Instance<br/>
        /// Creates a new compute instance with the specified configuration and SSH key.<br/>
        /// **Requirements:**<br/>
        /// - Requires compute permissions (extra_permissions.compute = true)<br/>
        /// - Authentication required via admin API key<br/>
        /// - Valid SSH public key required for instance access<br/>
        /// **Key Features:**<br/>
        /// - Create high-performance GPU instances<br/>
        /// - Specify sector for InfiniBand configuration (8x H100 only)<br/>
        /// - SSH key-based authentication<br/>
        /// - Automatic instance provisioning and region assignment<br/>
        /// - Idempotent creation with Idempotency-Key header (optional but recommended)<br/>
        /// **Common Use Cases:**<br/>
        /// - Spin up compute resources for ML training<br/>
        /// - Create GPU instances for inference workloads<br/>
        /// - Set up development environments with H100 GPUs<br/>
        /// - Deploy distributed training with InfiniBand networking<br/>
        /// **Instance Types:**<br/>
        /// - `gpu_8x_h100_sxm5`: 8x NVIDIA H100 GPUs (high-performance, supports sector configuration for InfiniBand)<br/>
        /// - `gpu_1x_h100_sxm5`: 1x NVIDIA H100 GPU (standard)<br/>
        /// **Idempotency:**<br/>
        /// - Optional Idempotency-Key header prevents duplicate instance creation on retries<br/>
        /// - Responses cached for 10 minutes per unique key<br/>
        /// See [fal.ai docs](https://docs.fal.ai/compute) for more details.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateComputeInstanceResponse> CreateComputeInstanceAsync(

            global::G.CreateComputeInstanceRequest request,
            string? idempotencyKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Compute Instance<br/>
        /// Creates a new compute instance with the specified configuration and SSH key.<br/>
        /// **Requirements:**<br/>
        /// - Requires compute permissions (extra_permissions.compute = true)<br/>
        /// - Authentication required via admin API key<br/>
        /// - Valid SSH public key required for instance access<br/>
        /// **Key Features:**<br/>
        /// - Create high-performance GPU instances<br/>
        /// - Specify sector for InfiniBand configuration (8x H100 only)<br/>
        /// - SSH key-based authentication<br/>
        /// - Automatic instance provisioning and region assignment<br/>
        /// - Idempotent creation with Idempotency-Key header (optional but recommended)<br/>
        /// **Common Use Cases:**<br/>
        /// - Spin up compute resources for ML training<br/>
        /// - Create GPU instances for inference workloads<br/>
        /// - Set up development environments with H100 GPUs<br/>
        /// - Deploy distributed training with InfiniBand networking<br/>
        /// **Instance Types:**<br/>
        /// - `gpu_8x_h100_sxm5`: 8x NVIDIA H100 GPUs (high-performance, supports sector configuration for InfiniBand)<br/>
        /// - `gpu_1x_h100_sxm5`: 1x NVIDIA H100 GPU (standard)<br/>
        /// **Idempotency:**<br/>
        /// - Optional Idempotency-Key header prevents duplicate instance creation on retries<br/>
        /// - Responses cached for 10 minutes per unique key<br/>
        /// See [fal.ai docs](https://docs.fal.ai/compute) for more details.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="instanceType">
        /// Type of compute instance to create<br/>
        /// Example: gpu_1x_h100_sxm5
        /// </param>
        /// <param name="sshKey">
        /// SSH public key for accessing the instance (e.g., 'ssh-rsa AAAAB3...')<br/>
        /// Example: ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABgQC... user@host
        /// </param>
        /// <param name="sector">
        /// Sector for InfiniBand configuration (only valid with gpu_8x_h100_sxm5)<br/>
        /// Example: sector_1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateComputeInstanceResponse> CreateComputeInstanceAsync(
            global::G.CreateComputeInstanceRequestInstanceType instanceType,
            string sshKey,
            string? idempotencyKey = default,
            global::G.CreateComputeInstanceRequestSector? sector = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}