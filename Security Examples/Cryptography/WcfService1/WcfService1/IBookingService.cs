﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    
    public interface IBookingService
    {

        [OperationContract]
        Booking Get(int id);
        [OperationContract]
        IEnumerable<Booking> GetAll();


        [OperationContract]
        Equipment GetEquipment(int id);

        [OperationContract]
        IEnumerable<Equipment> GetAllEquipments();

        [OperationContract]
        void EditEquipment(Equipment equipment);

        [OperationContract]
        void Create(Equipment equipment);

    }

    
}