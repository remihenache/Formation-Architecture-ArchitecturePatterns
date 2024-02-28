### Gestionnaire de Tâches Simple

Le projet de base est un gestionnaire de tâches simple permettant à l'utilisateur d'ajouter, de visualiser et de supprimer des tâches. Initialement, le projet utilise le modèle MVP, mais on souhaiterait le faire évoluer vers MVVM.


### Exercice Pratique: Appliquer MVP

**Objectif :** Transformer le code ci-dessus en utilisant le modèle MVVM.

#### Instructions
1. **Séparation des Responsabilités** : Révisez le ViewModel pour identifier les actions qui modifient l'état (Commandes) et celles qui lisent l'état (Requêtes).
2. **Création de Commandes et Requêtes** : Transformez les méthodes d'action et de récupération de données du ViewModel en classes de commandes et de requêtes distinctes.
3. **Implémentation de `INotifyPropertyChanged`** : Assurez-vous que le ViewModel implémente toujours `INotifyPropertyChanged` pour le binding, mais réduisez sa responsabilité à la liaison des commandes et requêtes avec la vue.
5. **Adaptation de la Vue** : La vue doit interagir avec le ViewModel en utilisant des bindings pour exécuter des commandes et afficher les résultats des requêtes, sans logique métier directe.

