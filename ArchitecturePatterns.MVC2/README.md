### Contexte et Travail à Faire

L'application console simplifiée demande le nom de l'utilisateur et affiche un message de salutation. Le but est de refactoriser cette application en utilisant le modèle MVC, en introduisant des composants distincts pour la logique métier (Modèle), l'affichage et l'interaction utilisateur (Vue), et la coordination entre la vue et le modèle (Contrôleur).

### Étapes Détaillées

1. **Créer le Modèle (`LoginModel`)**:
    - Définir une classe `LoginModel` contenant une propriété pour stocker le nom de l'utilisateur et une méthode pour retourner le message de salutation basé sur le nom.

2. **Développer la Vue (`LoginView`)**:
    - Créer une interface `IObserver` avec une méthode `Update` pour que la vue puisse être notifiée des changements.
    - Implémenter une classe `LoginView` qui implémente `IObserver` et qui contient des méthodes pour afficher les prompts à l'utilisateur et pour afficher les messages.

3. **Implémenter le Contrôleur (`LoginController`)**:
    - Définir une classe `LoginController` qui contient des références au modèle et à la vue.
    - Ajouter des méthodes pour gérer les entrées de l'utilisateur, mettre à jour le modèle et notifier la vue des changements.

4. **Lier les Composants**:
    - Dans la méthode `Main`, instancier le modèle, la vue, et le contrôleur.
    - S'assurer que le contrôleur connaît le modèle et la vue, et que la vue s'abonne aux notifications du modèle via le contrôleur.

5. **Gérer les Notifications**:
    - Modifier le modèle pour qu'il notifie la vue à chaque fois que le message change, en utilisant le pattern observateur.

6. **Tester l'Application**:
    - Exécuter l'application pour tester l'interaction. La vue doit demander le nom, le contrôleur doit récupérer cette entrée et la transmettre au modèle, le modèle doit générer le message de salutation, et enfin, la vue doit afficher ce message.
