<template>
<div class="search">
 <em>
     <input v-model="searchpro" type="text"  placeholder="请输入搜索信息">
     <i class="fa fa-window-close clear_x" v-if="searchpro==''?false:true" @click="cleardata"></i>
     <i class="fa fa-search-plus"></i>
     <div class="search_menu">
	       <ul class="input_list">
	          <li v-for="(pro,index) in input_list" :key="index" @click="select(pro)">
	              <i>{{pro.id}} : </i>{{pro.name}}
	          </li>
	       </ul>
     </div>
 </em>
</div>
</template>

<script>
export default {
  name: "SearchInput",
  data() {
    return {
    searchpro:'',
    input_list: [
      {id:1, name:'602h-DJ01'},
      {id:2, name:'602h-DJ02'},
      {id:3, name:'602h-DJ03'},
      {id:4, name:'602h-DJ04'},
      {id:5, name:'602h-DJ05'},
    ]
    }
  },
  methods: {
    cleardata(){
      this.searchpro=''
    },
    select(pro) {
      this.searchpro = pro.name;
    }
  },
}
</script>

<style scoped>
.search{
	 background-color: white;
	 display: flex;
	 align-items: center;
	 position: absolute;  /*绝对位置*/
  }
.search input{
	  padding:5px;
	  font-style: normal;
	   border:none;   /*input框的边框不显示*/
	}
.search input:focus{
	   outline:none;  /*input框的边框获取时不显示*/
	}
.search .clear_x{
	   position: relative;  /*相对位置*/
	   width:25px;
	   top:3px;
	   right:25px;
	   border-right:1px solid rgb(190, 187, 187);
	}
.search i{
	   padding:5px;
	}

	.search_menu{
	   border-top:5px solid #3388FF;
	   display: none;
	   background-color: gold;
	   position: absolute;
	   top:30px;
	   width:100%;
	}
	.search_menu ul{
	    margin-bottom: 0;  /*去除ul的底部外边距*/
	 }
	 .search_menu li {
	    padding: 5px;
	    font-size: 1.1em;
	    cursor: pointer;
	 }
	 .search_menu li:hover{
	    background-color: beige;
	 }
	 .search:hover .search_menu {
	    display: block;
	 }

</style>
