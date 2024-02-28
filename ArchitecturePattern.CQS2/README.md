### Gestionnaire de Tâches Simple

Le projet de base est un gestionnaire de tâches simple permettant à l'utilisateur d'ajouter, de visualiser et de supprimer des tâches. Initialement, le projet utilise le modèle MVVM, mais on souhaiterait le faire évoluer vers CQS.


### Exercice Pratique: Appliquer MVP

**Objectif :** Transformer le code ci-dessus en utilisant le modèle CQS avec Mediator.

#### Instructions
1. **Analyse du ViewModel** : Examinez votre ViewModel MVVM pour identifier les opérations qui modifient l'état (commandes) et celles qui récupèrent l'état (requêtes).
2. **Séparation Commande/Requête** : Séparez les fonctions du ViewModel en commandes et requêtes distinctes selon le principe CQS. Chaque commande doit effectuer une action sans retourner de données, tandis que les requêtes doivent retourner des données sans modifier l'état.
3. **Implémentation des Interfaces** : Créez des interfaces pour vos commandes et requêtes afin de faciliter l'abstraction et le test.
4. **Intégration du Médiateur** : Introduisez un médiateur pour orchestrer l'appel des commandes et requêtes, réduisant ainsi le couplage entre les composants de votre application.
5. **Adaptation de la Vue** : Modifiez la Vue pour qu'elle utilise le médiateur afin de lancer des commandes ou des requêtes, suivant les interactions utilisateur.
6. **Test et Validation** : Assurez-vous que l'application fonctionne correctement, en validant que les commandes et les requêtes sont exécutées comme attendu à travers le médiateur.

