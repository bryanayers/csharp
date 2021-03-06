// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ContainerStateRunning is a running state of a container.
    /// </summary>
    public partial class Corev1ContainerStateRunning
    {
        /// <summary>
        /// Initializes a new instance of the Corev1ContainerStateRunning
        /// class.
        /// </summary>
        public Corev1ContainerStateRunning()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1ContainerStateRunning
        /// class.
        /// </summary>
        /// <param name="startedAt">Time at which the container was last
        /// (re-)started</param>
        public Corev1ContainerStateRunning(System.DateTime? startedAt = default(System.DateTime?))
        {
            StartedAt = startedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time at which the container was last (re-)started
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public System.DateTime? StartedAt { get; set; }

    }
}
