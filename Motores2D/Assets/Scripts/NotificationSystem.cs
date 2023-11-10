using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.Notifications.Android;
using System;

public class NotificationSystem : MonoBehaviour
{
    /*public static NotificationSystem instance;

    //AndroidNotificationChannel notifChannel;

    private void Awake()
    {
        if (instance) Destroy(this);
        else
        {
            //10:35
        }
    }

    private void Start()
    {
        /*notifChannel = new AndroidNotificationChannel()
        {
            Id = "reminder_notif_channel",
            Name = "Reminder Notification",
            Description = "Esta es mi descripcion",
            Importance = Importance.High
        };

        AndroidNotificationCenter.RegisterNotificationChannel(notifChannel);

        DisplayNotification("Termina tu juego", "Tengo secuestrada a tu mascota", DateTime.Now.AddHours(24));
    }

    public void DisplayNotification(string title, string description, DateTime fireTime)
    {
        var notification = new AndroidNotification();

        notification.Title = title;
        notification.Text = description;

        notification.SmallIcon = "icon_0";
        notification.LargeIcon = "";

        notification.FireTime = fireTime;

        AndroidNotificationCenter.SendNotification(notification, notifChannel.Id);
    }

    public void CancelNotification(int id)
    {
        AndroidNotificationCenter.CancelScheduleNotification(id);
    }
    }*/
}
