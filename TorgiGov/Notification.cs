using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TorgiGov
{
    internal class Notification
    {
        //public string? BidderOrgCode { get; set; }
        //public string? RightHolderCode { get; set; }
        //public string? DocumentType { get; set; }
        //public string? RegNum { get; set; }
        //public string? PublishDate { get; set; }
        //public string? Href { get; set; }

        //public string? RegNum { get; set; }
        //public string? PublishDate { get; set; }
        //public string? Href { get; set; }

        //public string? RegNum { get; set; }
        //public string? PublishDate { get; set; }
        //public string? Href { get; set; }

        public async Task ProcessingNotification()
        {
            List<string> notificationsLots = new List<string>();
            string path = "D:\\земля\\Аукционы\\spisok.txt";

            //for(int k = 1; k < 10; k++)
            //{
                for (int j = 1; j < 2; j++)
                {
                    string link = null;
                    if (j < 9)
                    {
                        link = $"https://torgi.gov.ru/new/opendata/7710568760-notice/data-2022070{j}T0000-2022070{j + 1}T0000-structure-20220401.json";
                    }
                    else if (j == 9)
                    {
                        link = $"https://torgi.gov.ru/new/opendata/7710568760-notice/data-20220709T0000-20220710T0000-structure-20220401.json";
                    }
                    else
                    {
                        link = $"https://torgi.gov.ru/new/opendata/7710568760-notice/data-202207{j}T0000-202207{j + 1}T0000-structure-20220401.json";
                    }

                //link = "https://torgi.gov.ru/new/opendata/7710568760-notice/data-20220706T0000-20220707T0000-structure-20220401.json";

                    DaytimeLinks daytimeLinks = new DaytimeLinks();

                    var linksNotifications = await daytimeLinks.ProcessingDailyLinks(link);
                    //List<string> linksNotifications = new List<string>();
                //linksNotifications.Add("https://torgi.gov.ru/new/opendata/7710568760-notice/docs/notice_21000004710000002108_7fea9f09-0f35-4e76-abe3-057f76152e0f.json");

                    if (linksNotifications.Count == 0)
                        continue;

                     

                    foreach (var linkNotification in linksNotifications)
                    {

                    var jsonElement = await JsonLinks.ProcessingJsonLinks(linkNotification);

                        JsonElement element;
                        JsonElement commonInfo;
                        var el1 = jsonElement.TryGetProperty("exportObject", out element);
                        if (el1 != true)
                            continue;
                        var el2 = element.TryGetProperty("structuredObject", out element);
                        if (el2 != true)
                            continue;
                        var el3 = element.TryGetProperty("notice", out element);
                        if (el3 != true)
                            continue;
                        var el5 = element.TryGetProperty("commonInfo", out commonInfo);
                        if (el5 != true)
                            continue;
                        var el4 = element.TryGetProperty("lots", out element);
                            if (el4 != true)
                                continue;
                    
                        JsonElement commonInfoHref;

                        var el9 = commonInfo.TryGetProperty("href", out commonInfoHref);
                        if (el9 != true)
                            continue;
                        var href = commonInfoHref.GetString();

                    //var arrayJson = jsonElement.GetProperty("exportObject")
                    //       .GetProperty("structuredObject").GetProperty("notice").GetProperty("lots");

                    //notificationsLots.Add(jsonElement);
                    var g = element.GetArrayLength();
                        for (int i = 0; i < element.GetArrayLength(); i++)
                        {
                            JsonElement addressElement;                                   //element[i].GetProperty("biddingObjectInfo").GetProperty("estateAddress").GetString();

                            var el6 = element[i].TryGetProperty("biddingObjectInfo", out addressElement);
                            if (el6 != true)
                                continue;
                            var el7 = addressElement.TryGetProperty("estateAddress", out addressElement);
                            if (el7 != true)
                                continue;
                            var address = addressElement.GetString();


                            JsonElement lotNameElement;

                            var el8 = element[i].TryGetProperty("lotName", out lotNameElement);
                            if (el8 != true)
                                continue;
                            var lotName = lotNameElement.GetString();

                           

                        //var lotName = element[i].GetProperty("lotName").GetString();

                        if (address.IndexOf("дмитровс") > -1 || address.IndexOf("Дмитровс") > -1 || address.IndexOf("сергиево") > -1 || address.IndexOf("Сергиево") > -1 || address.IndexOf("пушкинск") > -1 || address.IndexOf("Пушкинск") > -1)
                                if (lotName.IndexOf("земельн") > -1 || lotName.IndexOf("Земельн") > -1)
                                {
                                    notificationsLots.Add(href);
                                }
                            //notificationsLots.Add(jsonElement);
                        }
                    }
                }
            //}


            await File.AppendAllLinesAsync(path, notificationsLots);

            //var t = notificationsLots.Where(x => x.GetProperty("biddingObjectInfo").GetProperty("estateAddress").GetString().IndexOf("Дмитровс") != -1);


        }

    }
}
