// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ResourceRequirements describes the compute resource requirements.
    /// </summary>
    public partial class Corev1ResourceRequirements
    {
        /// <summary>
        /// Initializes a new instance of the Corev1ResourceRequirements class.
        /// </summary>
        public Corev1ResourceRequirements()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1ResourceRequirements class.
        /// </summary>
        /// <param name="limits">Limits describes the maximum amount of compute
        /// resources allowed. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/</param>
        /// <param name="requests">Requests describes the minimum amount of
        /// compute resources required. If Requests is omitted for a container,
        /// it defaults to Limits if that is explicitly specified, otherwise to
        /// an implementation-defined value. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/</param>
        public Corev1ResourceRequirements(IDictionary<string, string> limits = default(IDictionary<string, string>), IDictionary<string, string> requests = default(IDictionary<string, string>))
        {
            Limits = limits;
            Requests = requests;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets limits describes the maximum amount of compute
        /// resources allowed. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        [JsonProperty(PropertyName = "limits")]
        public IDictionary<string, string> Limits { get; set; }

        /// <summary>
        /// Gets or sets requests describes the minimum amount of compute
        /// resources required. If Requests is omitted for a container, it
        /// defaults to Limits if that is explicitly specified, otherwise to an
        /// implementation-defined value. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        [JsonProperty(PropertyName = "requests")]
        public IDictionary<string, string> Requests { get; set; }

    }
}
