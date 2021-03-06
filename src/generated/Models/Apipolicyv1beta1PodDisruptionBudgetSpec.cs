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
    /// PodDisruptionBudgetSpec is a description of a PodDisruptionBudget.
    /// </summary>
    public partial class Apipolicyv1beta1PodDisruptionBudgetSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Apipolicyv1beta1PodDisruptionBudgetSpec class.
        /// </summary>
        public Apipolicyv1beta1PodDisruptionBudgetSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Apipolicyv1beta1PodDisruptionBudgetSpec class.
        /// </summary>
        /// <param name="maxUnavailable">An eviction is allowed if at most
        /// "maxUnavailable" pods selected by "selector" are unavailable after
        /// the eviction, i.e. even in absence of the evicted pod. For example,
        /// one can prevent all voluntary evictions by specifying 0. This is a
        /// mutually exclusive setting with "minAvailable".</param>
        /// <param name="minAvailable">An eviction is allowed if at least
        /// "minAvailable" pods selected by "selector" will still be available
        /// after the eviction, i.e. even in the absence of the evicted pod.
        /// So for example you can prevent all voluntary evictions by
        /// specifying "100%".</param>
        /// <param name="selector">Label query over pods whose evictions are
        /// managed by the disruption budget.</param>
        public Apipolicyv1beta1PodDisruptionBudgetSpec(IntOrString maxUnavailable = default(IntOrString), IntOrString minAvailable = default(IntOrString), V1LabelSelector selector = default(V1LabelSelector))
        {
            MaxUnavailable = maxUnavailable;
            MinAvailable = minAvailable;
            Selector = selector;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an eviction is allowed if at most "maxUnavailable"
        /// pods selected by "selector" are unavailable after the eviction,
        /// i.e. even in absence of the evicted pod. For example, one can
        /// prevent all voluntary evictions by specifying 0. This is a mutually
        /// exclusive setting with "minAvailable".
        /// </summary>
        [JsonProperty(PropertyName = "maxUnavailable")]
        public IntOrString MaxUnavailable { get; set; }

        /// <summary>
        /// Gets or sets an eviction is allowed if at least "minAvailable" pods
        /// selected by "selector" will still be available after the eviction,
        /// i.e. even in the absence of the evicted pod.  So for example you
        /// can prevent all voluntary evictions by specifying "100%".
        /// </summary>
        [JsonProperty(PropertyName = "minAvailable")]
        public IntOrString MinAvailable { get; set; }

        /// <summary>
        /// Gets or sets label query over pods whose evictions are managed by
        /// the disruption budget.
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public V1LabelSelector Selector { get; set; }

    }
}
