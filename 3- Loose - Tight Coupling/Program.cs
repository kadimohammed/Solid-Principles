


using _3__Loose___Tight_Coupling;

NotificationService notification = new NotificationService(NotificationFactory.Create(NotificationMode.Sms)!);

notification.Notify();