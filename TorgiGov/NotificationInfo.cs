using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorgiGov
{
    internal class NotificationInfo
    {
        public NotificationExportObject? ExportObject { get; set; }
    }

    internal class NotificationExportObject
    {
        public NotificationStructuredObject? StructuredObject { get; set; }
        public List<NotificationAttachments>? Attachments { get; set; }
    }

    internal class NotificationAttachments
    {
        public List<NotificationAttachment>? AdditionalDetails { get; set; }
    }
    internal class NotificationAttachment
    {
        public string? ContentId { get; set; }
        public string? Url { get; set; }
        public string? DetachedSignature { get; set; }
    }


    internal class NotificationStructuredObject
    {
        public NotificationNotice? Notice { get; set; }
    }
    internal class NotificationNotice
    {
        public string? SchemeVersion { get; set; }
        public string? Id { get; set; }
        public string? RootId { get; set; }
        public string? Version { get; set; }
        public NotificationCommonInfo? CommonInfo { get; set; }           
        public NotificationBidderOrg? BidderOrg { get; set; }  
        public NotificationRightHolderInfo? RightHolderInfo { get; set; }
        public NotificationLots? Lots { get; set; }
        public NotificationBiddConditions? BiddConditions { get; set; }
        public NotificationTimeZone? TimeZone { get; set; }
        public NotificationAdditionalDetails? AdditionalDetails { get; set; }
        public NotificationSignedData? SignedData { get; set; }
        public NotificationDocs? Docs { get; set; }
    }

    internal class NotificationBiddConditions
    {
        public string? BiddStartTime { get; set; }
        public string? BiddEndTime { get; set; }
    }
    internal class NotificationTimeZone
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationAdditionalDetails
    {
        public List<NotificationAdditionalDetail>? AdditionalDetails { get; set; }
    }
    internal class NotificationAdditionalDetail
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
    }
    internal class NotificationSignedData
    {
        public string? Id { get; set; }
        public string? Size { get; set; }
        public string? Hash { get; set; }
        public string? FileType { get; set; }
    }
    internal class NotificationDocs
    {
        public List<NotificationDoc>? Docs { get; set; }
    }
    internal class NotificationDoc
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Hash { get; set; }
        public NotificationDocAttachmentType? AttachmentType { get; set; }
    }
    internal class NotificationDocAttachmentType
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationCommonInfo
    {
        public string? NoticeNumber { get; set; }
        public NotificationBiddType? BiddType { get; set; }   
        public NotificationBiddForm? BiddForm { get; set; }    
        public string? PublishDate { get; set; }
        public string? ProcedureName { get; set; }
        public string? Href { get; set; }
    }
    internal class NotificationBiddType
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationBiddForm
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationBidderOrg
    {
        public NotificationOrgInfo? OrgInfo { get; set; }
        public NotificationContactInfo? ContactInfo { get; set; }
    }
    internal class NotificationOrgInfo
    {
        public string? Code { get; set; } 
        public string? Name { get; set; }
        public string? INN { get; set; }
        public string? KPP { get; set; }
        public string? OGRN { get; set; }
        public string? OrgType { get; set; }
        public string? LegalAddress { get; set; }
        public string? ActualAddress { get; set; }
    }
    internal class NotificationContactInfo
    {
        public string? ContPerson { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }
    }

    internal class NotificationRightHolderInfo
    {
        public string? BiddOrgRightHolder { get; set; }
        public NotificationRightHolderOrg? RightHolderOrg { get; set; }
    }
    internal class NotificationRightHolderOrg
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? INN { get; set; }
        public string? KPP { get; set; }
        public string? OGRN { get; set; }
        public string? OrgType { get; set; }
        public string? LegalAddress { get; set; }
        public string? ActualAddress { get; set; }
    }
    internal class NotificationLots
    {
       public List<NotificationLot>? Lots { get; set; }
    }

    internal class NotificationLot
    {
        public string? LotNumber { get; set; }
        public string? LotStatus { get; set; }
        public string? LotName { get; set; }
        public string? LotDescription { get; set; }
        public NotificationLotCurrency? Currency { get; set; }
        public NotificationLotBiddingObjectInfo? BiddingObjectInfo { get; set; }
        public NotificationLotBiddingObjectInfoAdditionalDetails? AdditionalDetails { get; set; }
        public NotificationLotBiddingObjectInfoDocs? Docs { get; set; }
        public NotificationLotBiddingObjectInfoImageIds? ImageIds { get; set; }
    }

    internal class NotificationLotCurrency
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationLotBiddingObjectInfo
    {
        public NotificationLotBiddingObjectInfoSubjectRF? SubjectRF { get; set; }
        public string? EstateAddress { get; set; }
        public NotificationLotBiddingObjectInfoCategory? Category { get; set; }
        public NotificationLotBiddingObjectInfoOwnershipForms? OwnershipForms { get; set; }
        public NotificationLotBiddingObjectInfoCharacteristics? Characteristics { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoSubjectRF
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoCategory
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoOwnershipForms
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoCharacteristics
    {
        public Dictionary<int, object>? Characteristics { get; set; }

        public NotificationLotBiddingObjectInfoCharacteristics()
        {
            Characteristics = new Dictionary<int, object>() 
            {
                {1, new NotificationLotBiddingObjectInfoCharacteristic1() },
                {2, new NotificationLotBiddingObjectInfoCharacteristic2() },
                {3, new NotificationLotBiddingObjectInfoCharacteristic3() },
            };
        }
    }
    internal class NotificationLotBiddingObjectInfoCharacteristic1
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? CharacteristicValue { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoCharacteristic2
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? CharacteristicValue { get; set; }
        public NotificationLotBiddingObjectInfoCharacteristic2OKEI? OKEI { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoCharacteristic2OKEI
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoCharacteristic3
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public NotificationLotBiddingObjectInfoCharacteristic3CharacteristicValue? CharacteristicValue { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoCharacteristic3CharacteristicValue
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public NotificationLotBiddingObjectInfoCharacteristicCharacteristicValue? CharacteristicValue { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoCharacteristicCharacteristicValue
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoAdditionalDetails
    {
        public List<NotificationLotBiddingObjectInfoAdditionalDetail>? AdditionalDetails { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoAdditionalDetail
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoDocs
    {
        public List<NotificationLotBiddingObjectInfoDoc>? Docs { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoDoc
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Hash { get; set; }
        public NotificationLotBiddingObjectInfoDocAttachmentType? AttachmentType { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoDocAttachmentType
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoImageIds
    {
        public List<NotificationLotBiddingObjectInfoImageId>? ImageIds { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoImageId
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Hash { get; set; }
        public NotificationLotBiddingObjectInfoImageIdAttachmentType? AttachmentType { get; set; }
    }
    internal class NotificationLotBiddingObjectInfoImageIdAttachmentType
    {
        public string? Code { get; set; }
    }


}
