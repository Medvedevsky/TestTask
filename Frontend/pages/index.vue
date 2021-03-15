<template>

  <v-card height="200" width="300" id="card-id">

    <v-subheader >

      <v-btn width="250" @click="loadData()" id="btn-id">
          Кнопка 
      </v-btn>

    </v-subheader>
    
       <v-progress-circular
          id = "progress_circular_id"
          :indeterminate = "true"
          color="primary"
          v-if="loading"
       />
    
    <v-list id ="itemList">
      <v-list-item-group color="primary">
        <v-list-item 
          v-for="(item, i) in items" :key="i">
           <v-list-item-content>
             <v-list-item-title v-text="item"></v-list-item-title>
           </v-list-item-content>
        </v-list-item>
      </v-list-item-group>
    </v-list>
  </v-card>

</template>

<script>
import axios from "axios";

export default
{
  data: () =>
    ({
      el: '#card',
      selectedItem: 1,
      items: [],
      loading:false
    }),

  methods: {
    async loadData()
    {
      this.items = null
      this.loading = true

      await axios
        .get('http://localhost:5000/api/TextLine')
        .then(response => this.items = response.data)

      this.loading = false
    }
  }

}
</script>

<style>

#btn-id{
  display:block;
  margin:auto;
}

#card-id{
  height: 500;
  width: 500;
  margin-left: 40%;
}

#progress_circular_id{
  display: block;
  margin: auto;
  visibility: visible;
}
</style>