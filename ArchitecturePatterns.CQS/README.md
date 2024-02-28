### Gestionnaire de Tâches Simple

Le projet de base est un gestionnaire de tâches simple permettant à l'utilisateur d'ajouter, de visualiser et de supprimer des tâches. Initialement, le projet utilise le modèle MVVM, mais on souhaiterait le faire évoluer vers CQS.


### Exercice Pratique: Appliquer MVP

**Objectif :** Transformer le code ci-dessus en utilisant le modèle CQS.

#### Instructions

1. **Identifier les Composants** : Commencez par identifier clairement les composants Modèle, Vue et Présentateur de votre application MVP actuelle.
2. **Transformer le Présentateur en ViewModel** : Refactorez le Présentateur pour qu'il devienne un ViewModel. Ce ViewModel doit implémenter `INotifyPropertyChanged` pour la liaison de données.
3. **Modifier la Vue** : Adaptez la Vue pour qu'elle n'interagisse plus directement avec le Présentateur mais observe les propriétés du ViewModel, réagissant aux changements via des notifications.
4. **Liaison de Données** : Implémentez des mécanismes de liaison de données ("binding") entre la Vue et le ViewModel, en remplaçant les appels de méthodes par des liaisons aux propriétés.
5. **Testez** : Vérifiez que votre application fonctionne comme prévu, avec les mêmes fonctionnalités qu'auparavant, mais en utilisant l'architecture MVVM.
