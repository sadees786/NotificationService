using Notify.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Interfaces
{
    public interface INotificationService
    {
        Task NotifyByEmailAsync(
            string templateId,
            string emailAddress,
            Dictionary<string, dynamic> personalisation = null,
            string clientReference = null,
            string emailReplyToId = null
        );
        Task<TemplatePreviewResponse> PreviewEmailTemplate(string templateId, Dictionary<string, dynamic> personalisation);
    }
}
