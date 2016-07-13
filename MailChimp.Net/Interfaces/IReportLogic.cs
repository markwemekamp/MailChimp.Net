﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IReportLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    using System;

    /// <summary>
    /// The ReportLogic interface.
    /// </summary>
    public interface IReportLogic
    {
        Task<SentToResponse> GetSentToRecipientResponseAsync(string campaignId, QueryableBaseRequest request = null);
        Task<IEnumerable<Report>> GetAllReportsAsync(ReportRequest request = null);
        Task<IEnumerable<Advice>> GetCampaignAdviceAsync(string campaignId, BaseRequest request = null);
        Task<IEnumerable<UrlClicked>> GetClickReportAsync(string campaignId, QueryableBaseRequest request = null);
        Task<UrlClicked> GetClickReportDetailsAsync(string campaignId, string linkId, BaseRequest request = null);
        Task<ClickMember> GetClickReportMemberAsync(string campaignId, string linkId, string emailAddress, BaseRequest request = null);
        Task<IEnumerable<ClickMember>> GetClickReportMembersAsync(string campaignId, string linkId, QueryableBaseRequest request = null);
        Task<IEnumerable<Domain>> GetDomainPerformanceAsync(string campaignId, BaseRequest request = null);
        Task<EepUrlActivity> GetEepUrlReportAsync(string campaignId, BaseRequest request = null);
        Task<IEnumerable<EmailActivity>> GetEmailActivitiesAsync(string campaignId, QueryableBaseRequest request = null);
        Task<EmailActivity> GetEmailActivityAsync(string campaignId, string emailAddress, BaseRequest request = null);
        Task<IEnumerable<OpenLocation>> GetLocationsAsync(string campaignId, BaseRequest request = null);
        Task<Report> GetReportAsync(string campaignId, BaseRequest request = null);
        Task<ReportResponse> GetResponseAsync(ReportRequest request = null);
        Task<SentTo> GetSentToRecipientAsync(string campaignId, string emailAddress, QueryableBaseRequest request = null);
        Task<IEnumerable<SentTo>> GetSentToRecipientsAsync(string campaignId, QueryableBaseRequest request = null);
        Task<IEnumerable<Report>> GetSubReportAsync(string campaignId, BaseRequest request = null);
        Task<Unsubscribe> GetUnsubscriberAsync(string campaignId, string emailAddress, BaseRequest request = null);
        Task<IEnumerable<Unsubscribe>> GetUnsubscribesAsync(string campaignId, QueryableBaseRequest request = null);
    }
}