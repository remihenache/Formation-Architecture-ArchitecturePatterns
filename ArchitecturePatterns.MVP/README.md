### Gestionnaire de Tâches Simple

Le projet de base est un gestionnaire de tâches simple permettant à l'utilisateur d'ajouter, de visualiser et de supprimer des tâches. Initialement, le projet utilise le modèle MVC, mais on souhaiterait le faire évoluer vers MVP.


### Exercice Pratique: Appliquer MVP

**Objectif :** Transformer le code ci-dessus en utilisant le modèle MVP en se basant sur l'architecture MVC en place.

#### Instructions

1. **Créer le Modèle :** Séparez la logique de gestion des tâches (ajout, suppression) dans des classes spécifiques au domaine métier.
2. **Développer la Vue :** Isoler les interactions utilisateur dans une classe dédiée pour clarifier le code et faciliter les modifications de l'interface.
3. **Implémenter le Contrôleur :** Faites en sorte que le contrôleur coordonne les actions entre la vue et le modèle, en déclenchant les mises à jour nécessaires.
4. **Brancher le Contrôleur dans le main:** Modifier le program main pour utiliser votre nouvelle structure.
